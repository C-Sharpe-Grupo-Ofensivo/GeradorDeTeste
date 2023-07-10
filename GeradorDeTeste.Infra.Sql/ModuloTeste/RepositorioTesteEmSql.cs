using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTestes.Dominio.ModuloTeste;
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
														INNER JOIN [DISCIPLINA] AS D
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
														INNER JOIN [DISCIPLINA] AS D
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
			@"DELETE FROM TBQUESTAO_TBTESTE
				WHERE TESTE_ID = @TESTE_ID AND QUESTAO_ID = @QUESTAO_ID";

		private const string sqlCarregasQuestoesTeste = @"SELECT 
				Q.ID                QUESTAO_ID, 
				Q.MATERIA_ID        QUESTAO_MATERIA_ID, 
				Q.ENUNCIADO         QUESTAO_ENUNCIADO,
				Q.RESPOSTA          QUESTAO_RESPOSTA,

				TBT.TESTE_ID        TESTE_ID,
				
				M.ID                MATERIA_ID,
				M.NOME              MATERIA_NOME,
				M.DISCIPLINA_ID     DISCIPLINA_ID,
				M.SERIE             MATERIA_SERIE,

				D.ID             DISCIPLINA_ID,
				D.NOME           DISCIPLINA_NOME
				
			FROM 
				[QUESTAO] Q

				INNER JOIN TBQUESTAO_TBTESTE TBT
					ON Q.ID = TBT.QUESTAO_ID

				INNER JOIN TBMATERIA M
					ON Q.MATERIA_ID = M.ID
	
				INNER JOIN DISCIPLINA D
					ON M.DISCIPLINA_ID = D.ID

			WHERE 

				TBT.TESTE_ID = @TESTE_ID";
	}
}
