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
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.disciplina);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);
            string serie = Convert.ToString(leitorRegistros["SERIE"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            return new Materia(id, nome, disciplina, serie);
        }

    
    }
}