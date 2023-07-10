using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTeste.Infra.Sql.ModuloDisciplina;
using GeradorDeTeste.Infra.Sql.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTeste.Infra.Sql.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@NOME", registro.nome);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.disciplina.id);
            comando.Parameters.AddWithValue("@MATERIA_ID", registro.materia.id);
            comando.Parameters.AddWithValue("@RECUPERACAO", registro.recuperacao);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["TESTE_ID"]);
            string nome = Convert.ToString(leitorRegistros["TESTE_NOME"]);
            bool recuperacao = Convert.ToBoolean(leitorRegistros["TESTE_RECUPERACAO"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            return new Teste(id, nome, materia, recuperacao, disciplina);
        }
    }
}
