using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Infra.Sql.ModuloMateria
{
	public class RepositorioMateriaEmSql : RepositorioEmSqlBase<Materia, MapeadorMateria>, IRepositorioMateria
	{
		protected override string sqlInserir => @"INSERT INTO [DBO]. [TBMATERIA]
													(
													  [NOME]
													  ,[DISCIPLINA_ID]
													  ,[SERIE]
													)
													VALUES
													(
													   @NOME
													  ,@DISCIPLINA_ID
													  ,@SERIE
													);
													SELECT SCOPE_IDENTITY();";


		protected override string sqlEditar => @"UPDATE[TBMATERIA]
											   SET
												   [NOME] = @NOME
												  ,[DISCIPLINA_ID] = @DISCIPLINA_ID
												  ,[SERIE] = @SERIE
											 WHERE [ID] = @ID;";

		protected override string sqlExcluir => @"DELETE FROM [TBMATERIA]
													WHERE 
														[ID] = @ID";

		protected override string sqlSelecionarTodos => @"SELECT 
															M.[ID]              MATERIA_ID 
														   ,M.[NOME]            MATERIA_NOME
														   ,M.[DISCIPLINA_ID]   DISCIPLINA_ID
														   ,M.[SERIE]           MATERIA_SERIE
														   ,D.[NOME]            DISCIPLINA_NOME
														FROM 
															[TBMATERIA] AS M
														INNER JOIN [DISCIPLINA] AS D
																ON M.[DISCIPLINA_ID] = D.ID";

		protected override string sqlSelecionarPorId => @"SELECT 
														M.[ID]             MATERIA_ID 
													   ,M.[NOME]           MATERIA_NOME
													   ,M.[DISCIPLINA_ID]  DISCIPLINA_ID
													   ,M.[SERIE]          MATERIA_SERIE
													   ,D.[NOME]           DISCIPLINA_NOME
													FROM 
														[TBMATERIA] AS M
													INNER JOIN [DISCIPLINA] AS D
															ON M.[DISCIPLINA_ID] = D.ID
													WHERE 
														M.[ID] = @ID";

		public override List<Materia> SelecionarTodos()
		{
			List<Materia> materias = base.SelecionarTodos();

			return materias;
		}

		public override Materia SelecionarPorId(int id)
		{
			Materia materia = base.SelecionarPorId(id);

			return materia;
		}
	}
}
