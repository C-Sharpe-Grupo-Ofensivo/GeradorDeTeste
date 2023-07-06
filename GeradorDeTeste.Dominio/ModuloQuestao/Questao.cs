using GeradorDeTestes.Dominio.ModuloMateria;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Materia materia {get; set;}
        public string resposta { get; set; }
        public string enunciado { get; set; }
        public List<Alternativa> alternativas { get; set; }
        public string alternativaCorreta { get; set; }
        public Questao(int id, Materia materia, string resposta, string enunciado) : this()
        {
            this.id = id;
            this.materia = materia;
            this.resposta = resposta;
            this.enunciado = enunciado;
            this.alternativas = alternativas;
        }

        public Questao(Materia materia, string resposta, string enunciado, List<Alternativa> alternativa)
        {
            this.materia = materia;
            this.resposta = resposta;
            this.enunciado = enunciado;
            this.alternativas = alternativa;
        }

        public Questao()
        {
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            this.resposta = registroAtualizado.resposta;
            this.enunciado = registroAtualizado.enunciado;
            this.alternativas = registroAtualizado.alternativas;

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

            if (string.IsNullOrEmpty(alternativas.ToString()))
                erros.Add("O campo 'Alterantiva' é obrigatório");
            return erros.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Questao questao &&
                   id == questao.id &&
                   resposta == questao.resposta &&
                   enunciado == questao.enunciado &&
                   alternativas == questao.alternativas;
        }
        public void AdicionarAlternativa(Alternativa alternativa)
        {
            if (alternativas.Contains(alternativa) == false)
                alternativas.Add(alternativa);
        }
        public void RemoverAlternativa(Alternativa alternativa)
        {
            alternativas.Remove(alternativa);
        }
        public bool Contem(Alternativa alternativa)
        {
            return alternativas.Contains(alternativa);
        }
    }
}
