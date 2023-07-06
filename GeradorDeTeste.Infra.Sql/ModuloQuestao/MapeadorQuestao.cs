using GeradorDeTeste.Infra.Sql.Compartilhado;
using GeradorDeTeste.Infra.Sql.ModuloMateria;
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
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);

            comando.Parameters.AddWithValue("MATERIA_ID", registro.materia.id);

            comando.Parameters.AddWithValue("ENUNCIADO", registro.enunciado);

            comando.Parameters.AddWithValue("RESPOSTA", registro.resposta);
        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {

            int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);

            string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"]);

            string resposta = Convert.ToString(leitorRegistros["QUESTAO_RESPOSTA"]);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            Questao questao = new Questao(id, materia, resposta, enunciado);

            return questao;
        }
    }
}
