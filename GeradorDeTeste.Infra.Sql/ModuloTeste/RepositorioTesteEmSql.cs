using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTeste.Infra.Sql.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Infra.Sql.ModuloTeste
{
	public class RepositorioTesteEmSql : RepositorioEmSqlBase<Teste, MapeadorTeste>, IRepositorioTeste
	{
		protected override string sqlInserir => @"INSERT INTO[DBO].[TBTESTE]
													(
														[NOME]
													   ,[DISCIPLINA_ID]
													   ,[MATERIA_ID]
													   ,[RECUPERACAO]
													)
												 VALUES
													(
														@NOME
													   ,@DISCIPLINA_ID
													   ,@MATERIA_ID
													   ,@RECUPERACAO
													);
												 SELECT SCOPE_IDENTITY()";

		protected override string sqlEditar => @"UPDATE[TBTESTE]
											   SET
													[NOME] = @NOME
												   ,[DISCIPLINA_ID] = @DISCIPLINA_ID
												   ,[MATERIA_ID] = @MATERIA_ID
												   ,[QUANTIDADEQUESTOES] = @QUANTIDADEQUESTOES
												   ,[PROVARECUPERACAO] = @PROVARECUPERACAO
											 WHERE [ID] = @ID";

		protected override string sqlExcluir => @"DELETE FROM [TBTESTE]
													WHERE 
														[ID] = @ID";

        protected  string sqlExcluirQuestoes => @"DELETE FROM [TBTESTE_TBQUESTAO]
													WHERE 
														[TESTE_ID] = @TESTE_ID";

        protected override string sqlSelecionarTodos => @"SELECT 
															T.[ID]                  TESTE_ID 
														   ,T.[NOME]                TESTE_NOME
														   ,T.[DISCIPLINA_ID]       TESTE_DISCIPLINA_ID
														   ,T.[MATERIA_ID]          TESTE_MATERIA_ID
														   ,T.[RECUPERACAO]         TESTE_RECUPERACAO
														   ,M.[ID]                  MATERIA_ID
														   ,M.[NOME]                MATERIA_NOME
														   ,M.[SERIE]               MATERIA_SERIE
														   ,M.[DISCIPLINA_ID]       DISCIPLINA_ID
														   ,D.[ID]                  DISCIPLINA_ID
														   ,D.[NOME]                DISCIPLINA_NOME

														FROM 
															[TBTESTE] AS T
														INNER JOIN [TBMATERIA] AS M
																ON T.[MATERIA_ID] = M.ID
														INNER JOIN [TBDISCIPLINA] AS D
																ON M.[DISCIPLINA_ID] = D.ID";


		protected override string sqlSelecionarPorId => @"SELECT 
															T.[ID]                  TESTE_ID 
														   ,T.[NOME]                TESTE_NOME
														   ,T.[DISCIPLINA_ID]       TESTE_DISCIPLINA_ID
														   ,T.[MATERIA_ID]          TESTE_MATERIA_ID
														   ,T.[RECUPERACAO]         TESTE_RECUPERACAO
														   ,M.[ID]                  MATERIA_ID
														   ,M.[NOME]                MATERIA_NOME
														   ,M.[SERIE]               MATERIA_SERIE
														   ,M.[DISCIPLINA_ID]       DISCIPLINA_ID
														   ,D.[ID]                  DISCIPLINA_ID
														   ,D.[NOME]                DISCIPLINA_NOME
													FROM 
															[TBTESTE] AS T
														INNER JOIN [TBMATERIA] AS M
																ON T.[MATERIA_ID] = M.ID
														INNER JOIN [TBDISCIPLINA] AS D
																ON M.[DISCIPLINA_ID] = D.ID
													WHERE 
														T.[ID] = @ID";

		private const string sqlAdicionarQuestao =
			@"INSERT INTO [TBTESTE_TBQUESTAO]
				(
					[QUESTAO_ID]
				   ,[TESTE_ID]
				)
			VALUES
				(
					@QUESTAO_ID
				   ,@TESTE_ID
				)";

		private const string sqlCarregarQuestoes =
			@"SELECT 
				Q.ID            QUESTAO_ID, 
				Q.MATERIA_ID    QUESTAO_MATERIA_ID, 
				Q.ENUNCIADO     QUESTAO_ENUNCIADO,
				Q.RESPOSTA      QUESTAO_RESPOSTA,
				
				M.ID             MATERIA_ID,
				M.NOME           MATERIA_NOME,
				M.DISCIPLINA_ID  DISCIPLINA_ID,
				M.SERIE          MATERIA_SERIE,

				D.ID             DISCIPLINA_ID,
				D.NOME           DISCIPLINA_NOME
			FROM 
				[QUESTAO] Q

				INNER JOIN TBMATERIA M

					ON Q.MATERIA_ID = M.ID

				INNER JOIN DISCIPLINA D

					ON M.DISCIPLINA_ID = D.ID
			WHERE 

				Q.MATERIA_ID = @MATERIA_ID AND M.DISCIPLINA_ID = @DISCIPLINA_ID";

		private const string sqlRemoverQuestoes =
			@"DELETE FROM TBTESTE_TBQUESTAO
				WHERE TESTE_ID = @TESTE_ID";

		private const string sqlCarregasQuestoesTeste = @"SELECT 
				Q.ID                QUESTAO_ID, 
				Q.MATERIA_ID        QUESTAO_MATERIA_ID, 
				Q.ENUNCIADO         QUESTAO_ENUNCIADO,
				Q.RESPOSTA          QUESTAO_RESPOSTA,

				TB.TESTE_ID        TESTE_ID,
				
				M.ID                MATERIA_ID,
				M.NOME              MATERIA_NOME,
				M.DISCIPLINA_ID     DISCIPLINA_ID,
				M.SERIE             MATERIA_SERIE,

				D.ID             DISCIPLINA_ID,
				D.NOME           DISCIPLINA_NOME
				
			FROM 
				[TBQUESTAO] AS Q

				INNER JOIN TBTESTE_TBQUESTAO AS TB
					ON Q.ID = TB.QUESTAO_ID

				INNER JOIN TBMATERIA AS M
					ON Q.MATERIA_ID = M.ID
	
				INNER JOIN TBDISCIPLINA AS D
					ON M.DISCIPLINA_ID = D.ID

			WHERE 

				TB.TESTE_ID = @TESTE_ID";

        public void Inserir(Teste novoRegistro, List<Questao> questoesAdicionadas)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            MapeadorTeste mapeador = new MapeadorTeste();

            mapeador.ConfigurarParametros(comandoInserir, novoRegistro);

            object id = comandoInserir.ExecuteScalar();

            novoRegistro.id = Convert.ToInt32(id);

            conexaoComBanco.Close();

            foreach (Questao questao in questoesAdicionadas)
            {
                AdicionarQuestao(novoRegistro, questao);
            }
        }

        public void Excluir(Teste registroSelecionado)
        {
            
                RemoverQuestao(registroSelecionado);
            

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluir;

            comandoExcluir.Parameters.AddWithValue("ID", registroSelecionado.id);

            comandoExcluir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void AdicionarQuestao(Teste teste, Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlAdicionarQuestao;

            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoInserir.Parameters.AddWithValue("TESTE_ID", teste.id);

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void CarregarQuestoes(Teste teste)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarItens = conexaoComBanco.CreateCommand();
            comandoSelecionarItens.CommandText = sqlCarregasQuestoesTeste;
			
            comandoSelecionarItens.Parameters.AddWithValue("TESTE_ID", teste.id);
           

            SqlDataReader leitorQuestao = comandoSelecionarItens.ExecuteReader();

            while (leitorQuestao.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();

                Questao questao = mapeador.ConverterRegistro(leitorQuestao);

                teste.AdicionarQuestao(questao);
            }

            conexaoComBanco.Close();
        }

        private void RemoverQuestao(Teste teste)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlRemoverQuestoes;

            comandoInserir.Parameters.AddWithValue("TESTE_ID", teste.id);
            

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public Teste SelecionarPorId(int id)
        {
            Teste teste = base.SelecionarPorId(id);

            if (teste != null)
                CarregarQuestoes(teste);

            return teste;
        }

        public List<Teste> SelecionarTodos()
        {
            List<Teste> testes = base.SelecionarTodos();

            return testes;
        }
    }
}
