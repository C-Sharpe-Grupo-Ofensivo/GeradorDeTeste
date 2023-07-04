using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using Microsoft.Data.SqlClient;

namespace GeradorDeTeste.Infra.Sql.ModuloDisciplina
{
	public class RepositorioDisciplinaEmSql : RepositorioEmSqlBase<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
	{
		protected override string sqlInserir =>
			@"INSERT INTO [TBDISCIPLINA] 
				(
					[NOME]
					
				)
				VALUES 
				(
					@NOME
				
				);                 

			SELECT SCOPE_IDENTITY();";

		protected override string sqlEditar =>
			@"UPDATE [TBDISCIPLINA] 
				SET 
					[NOME] = @NOME,
				
				WHERE 
					[ID] = @ID";

		protected override string sqlExcluir =>
			@"DELETE FROM [TBDISCIPLINA]
				WHERE 
					[ID] = @ID";

		protected override string sqlSelecionarTodos =>
			@"SELECT 

				[ID]        CLIENTE_ID 
			   ,[NOME]      CLIENTE_NOME
		

			FROM 
				[TBDISCIPLINA]";

		protected override string sqlSelecionarPorId =>
			@"SELECT 

				[ID]        CLIENTE_ID 
			   ,[NOME]      CLIENTE_NOME
			

			FROM 
				[TBDISCIPLINA] 
			WHERE 
				[ID] = @ID";


		

	}
}
