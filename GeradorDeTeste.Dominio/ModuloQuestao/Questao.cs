using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Materia materia {get; set;}
        public string resposta { get; set; }
        public string enunciado { get; set; }
        public List<Alternativa> alternativa { get; set; }
        public string alternativaCorreta { get; set; }
        public Questao(int id, string resposta, string enunciado, List<Alternativa> alternativa) : this()
        {
            this.id = id;
            this.resposta = resposta;
            this.enunciado = enunciado;
            this.alternativa = alternativa;
        }

        public Questao(string resposta, string enunciado, List<Alternativa> alternativa)
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

            if (string.IsNullOrEmpty(alternativa.ToString()))
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
