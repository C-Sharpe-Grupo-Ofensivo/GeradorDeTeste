using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTeste.Infra.Sql.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Infra.Sql.ModuloQuestao
{
	public class RepositorioQuestaoEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestao>, IRepositorioQuestao
	{
		protected override string sqlInserir =>
			@"INSERT INTO [TBQUESTAO] 
				(
					
					[ENUNCIADO]
					,[MATERIA_ID]
					,[RESPOSTA]
				)
				VALUES 
				(
				
					@ENUNCIADO
					,@MATERIA_ID
					,@RESPOSTA
				
				);                 

			SELECT SCOPE_IDENTITY();";

		protected override string sqlEditar =>
			@"UPDATE [TBQUESTAO] 
				SET 
					[ENUNCIADO] = @ENUNCIADO
					, [MATERIA_ID] = @MATERIA_ID
					, [RESPOSTA] = @RESPOSTA
				WHERE 
					[ID] = @ID";

		protected override string sqlExcluir =>
			@"DELETE FROM [TBQUESTAO]
				WHERE 
					[ID] = @ID";

		protected string sqlInserirAlternativa =>
			@"INSERT INTO [TBQUESTAO]
			(
				[ALTERNATIVA]
				, [QUESTAO_ID]
			)
			VALUES
			(
				@ALTERNATIVA
				@ID
			);

			SELECT SCOPE_IDENTITY()";

		protected string sqlEditarAlternativa =>
			@"UPDATE FROM [TBQUESTAO]
			SET
				[ALTERNATIVA] = @ALTERNATIVA
			WHERE
				[QUESTAO_ID] = @ID";

		protected string sqlExcluirAlternativa =>
			@"DELETE FROM [TBQUESTAO]
			WHERE 
				[QUESTAO_ID] = @ID";

		protected override string sqlSelecionarTodos =>
			@"SELECT 

				QUESTAO.[ID]        QUESTAO_ID
				, QUESTAO.[ENUNCIADO]      QUESTAO_ENUNCIADO
				, QUESTAO.[MATERIA_ID]		MATERIA_ID
				, QUESTAO.[RESPOSTA]		QUESTAO_RESPOSTA
				, MATERIA.[NOME]		MATERIA_NOME
				, MATERIA.[SERIE]		MATERIA_SERIE
				, MATERIA.[DISCIPLINA_ID]		DISCIPLINA_ID
				, DISCIPLINA.[NOME]		DISCIPLINA_NOME
			FROM 
				[TBQUESTAO] as QUESTAO
				INNER JOIN [TBMATERIA] as MATERIA
				on QUESTAO.[MATERIA_ID] = MATERIA.ID

				INNER JOIN [TBDISCIPLINA] as DISCIPLINA
				on MATERIA.[DISCIPLINA_ID] = DISCIPLINA.ID";

		protected override string sqlSelecionarPorId =>
			@"SELECT 

				QUESTAO.[ID]        QUESTAO_ID
				, QUESTAO.[ENUNCIADO]      QUESTAO_ENUNCIADO
				, QUESTAO.[MATERIA_ID]		MATERIA_ID
				, QUESTAO.[RESPOSTA]		QUESTAO_RESPOSTA
				, MATERIA.[NOME]		MATERIA_NOME
				, MATERIA.[SERIE]		MATERIA_SERIE
				, MATERIA.[DISCIPLINA_ID]		DISCIPLINA_ID
				, DISCIPLINA.[NOME]		DISCIPLINA_NOME

			FROM 
				[TBQUESTAO] as QUESTAO
				INNER JOIN [TBMATERIA] as MATERIA
				on QUESTAO.[MATERIA_ID] = MATERIA.ID

				INNER JOIN [TBDISCIPLINA] as DISCIPLINA
				on MATERIA.[DISCIPLINA_ID] = DISCIPLINA.ID
			WHERE 
				QUESTAO.[ID] = @ID";

		private const string sqlCarregarAlternativas =
			@"SELECT 
				A.[ID]            ALTERNATIVA_ID
				, A.[RESPOSTA]      ALTERNATIVA_RESPOSTA
				, A.[VERDADEIRO]      ALTERNATIVA_VERDADEIRA
				, A.[QUESTAO_ID]        ALTERNATIVA_QUESTAO_ID
			FROM 
				[TBALTERNATIVA] AS A
	
				INNER JOIN [TBQUESTAO] AS Q
		
					ON  A.[QUESTAO_ID] = Q.[ID]
			WHERE 

				A.QUESTAO_ID = @QUESTAO_ID";

		public void Inserir(Questao novaQuestao, List<Alternativa> alternativasAdicionadas)
		{
			MapeadorQuestao mapeadorQuestao = new MapeadorQuestao();

			foreach (Alternativa item in alternativasAdicionadas)
			{
				novaQuestao.AdicionarAlternativa(item);
			}
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlInserir;

			mapeadorQuestao.ConfigurarParametros(comandoInserir, novaQuestao);

			object id = comandoInserir.ExecuteScalar();

			novaQuestao.id = Convert.ToInt32(id);

			conexaoComBanco.Close();

			foreach (Alternativa item in alternativasAdicionadas)
			{
				AdicionarAlternativa(item, novaQuestao);
			}
		}
		private void AdicionarAlternativa(Alternativa alternativa, Questao questao)
		{
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlInserirAlternativa;

			comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
			comandoInserir.Parameters.AddWithValue("RESPOSTA", questao.resposta);
			comandoInserir.Parameters.AddWithValue("ALTERNATIVA", alternativa.alternativa);

			comandoInserir.ExecuteNonQuery();

			conexaoComBanco.Close();
		}
		public void Editar(int id, Questao questao, List<Alternativa> alternativaMarcada, List<Alternativa> alternativaDesmarcada)
		{
			MapeadorQuestao mapeadorQuestao = new MapeadorQuestao();

			foreach (Alternativa item in alternativaMarcada)
			{
				if (questao.Contem(item))
					continue;

				AdicionarAlternativa(item, questao);
				questao.AdicionarAlternativa(item);
			}

			foreach (Alternativa item in alternativaDesmarcada)
			{
				if (questao.Contem(item))
				{
					RemoverAlternativa(item, questao);
					questao.RemoverAlternativa(item);
				}
			}
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
			comandoEditar.CommandText = sqlEditar;

			mapeadorQuestao.ConfigurarParametros(comandoEditar, questao);

			comandoEditar.ExecuteNonQuery();

			conexaoComBanco.Close();
		}
		private void RemoverAlternativa(Alternativa alternativa, Questao questao)
		{
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlExcluirAlternativa;

			comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
			comandoInserir.Parameters.AddWithValue("ALTERNATIVA", alternativa.alternativa);

			comandoInserir.ExecuteNonQuery();

			conexaoComBanco.Close();
		}
		public void Excluir(Questao questaoSelecionada)
		{
			foreach (Alternativa item in questaoSelecionada.alternativas)
			{
				RemoverAlternativa(item, questaoSelecionada);
			}

			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
			comandoExcluir.CommandText = sqlExcluir;

			comandoExcluir.Parameters.AddWithValue("ID", questaoSelecionada.id);

			comandoExcluir.ExecuteNonQuery();

			conexaoComBanco.Close();
		}
		public Questao SelecionarPorId(int id)
		{
			MapeadorQuestao mapeadorQuestao = new MapeadorQuestao();

			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
			comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

			comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

			SqlDataReader leitorQuestao = comandoSelecionarPorId.ExecuteReader();

			Questao questao = null;

			if (leitorQuestao.Read())
				questao = mapeadorQuestao.ConverterRegistro(leitorQuestao);

			conexaoComBanco.Close();

			if (questao != null)
			{
				CarregarAlternativas(questao);
			}

			return questao;
		}
		public void CarregarAlternativas(Questao questao)
		{
			MapeadorQuestao mapeadorQuestao = new MapeadorQuestao();

			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoSelecionarItens = conexaoComBanco.CreateCommand();
			comandoSelecionarItens.CommandText = sqlCarregarAlternativas;

			comandoSelecionarItens.Parameters.AddWithValue("QUESTAO_ID", questao.id);

			SqlDataReader leitorQuestao = comandoSelecionarItens.ExecuteReader();

			while (leitorQuestao.Read())
			{
				Alternativa alternativa = mapeadorQuestao.ConverterParaAlternativa(leitorQuestao);

				questao.AdicionarAlternativa(alternativa);
			}

			conexaoComBanco.Close();
		}
		public List<Questao> SelecionarTodos(bool carregarAlternativas = false)
		{
			MapeadorQuestao mapeadorQuestao = new MapeadorQuestao();

			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
			comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

			SqlDataReader leitorQuestao = comandoSelecionarTodos.ExecuteReader();

			List<Questao> questoes = new List<Questao>();

			while (leitorQuestao.Read())
			{
				Questao questao = mapeadorQuestao.ConverterRegistro(leitorQuestao);

				if (carregarAlternativas)
					CarregarAlternativas(questao);

				questoes.Add(questao);
			}

			conexaoComBanco.Close();

			return questoes;
		}
	}
}
