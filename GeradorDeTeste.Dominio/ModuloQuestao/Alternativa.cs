using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string alternativa { get; set; }
        public Questao questao { get; set; }
        public bool alternativaCorreta { get; set; }
        public Alternativa() { }
        public Alternativa(string alternativa, Questao questao) 
        {
            this.alternativa = alternativa;
            this.questao = questao;
            alternativaCorreta = false;
        }
        
        public override void AtualizarInformacoes(Alternativa registroAtualizado)
        {
            this.alternativa = registroAtualizado.alternativa;
            this.alternativaCorreta = registroAtualizado.alternativaCorreta;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (alternativa == null)
                erros.Add("O campo 'Alternativa' é obrigatório");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return alternativa.ToString();
        }
    }
}
