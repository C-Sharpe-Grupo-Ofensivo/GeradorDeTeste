using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTeste.Infra.Sql.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTeste.Infra.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
     

        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@NOME", registro.nome);
            comando.Parameters.AddWithValue("@SERIE", registro.serie);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.disciplina.id);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);
            int serie = Convert.ToInt32(leitorRegistros["MATERIA_SERIE"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            return new Materia(id, nome, disciplina, serie);
        }

    
    }
}