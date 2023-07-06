using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        //public Materia materia {get; set;}
        public string resposta { get; set; }
        public string enunciado { get; set; }
        public string alternativa { get; set; }
        public Questao(int id, string resposta, string enunciado, string alternativa) : this()
        {
            this.id = id;
            this.resposta = resposta;
            this.enunciado = enunciado;
            this.alternativa = alternativa;
        }

        public Questao(string resposta, string enunciado, string alternativa)
        {
            this.resposta = resposta;
            this.enunciado = enunciado;
            this.alternativa = alternativa;
        }

        public Questao()
        {
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            this.resposta = registroAtualizado.resposta;
            this.enunciado = registroAtualizado.enunciado;
            this.alternativa = registroAtualizado.alternativa;
        }
        public override string ToString()
        {
            return $"{resposta}";
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(resposta))
                erros.Add("O campo 'Resposta' é obrigatório");

            if (string.IsNullOrEmpty(enunciado))
                erros.Add("O campo 'Enunciado' é obrigatório");

            if (string.IsNullOrEmpty(alternativa))
                erros.Add("O campo 'Alterantiva' é obrigatório");
            return erros.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Questao questao &&
                   id == questao.id &&
                   resposta == questao.resposta &&
                   enunciado == questao.enunciado &&
                   alternativa == questao.alternativa;
        }
    }
}
