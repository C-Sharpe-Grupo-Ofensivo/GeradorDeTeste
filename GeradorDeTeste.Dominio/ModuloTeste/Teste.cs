using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public Teste(int id,string nome, Materia materia, bool recuperacao, Disciplina disciplina)
        {
            this.id = id;
            this.nome = nome;
            this.materia = materia;
           
            this.recuperacao = recuperacao;
            this.disciplina = disciplina;
            this.questoes = questoes;
        }

        public string nome { get; set; }
        public Materia materia { get; set; }
    
        public bool recuperacao { get; set; }
        public Disciplina disciplina { get; set; }
        public List<Questao> questoes { get; set; }

        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.materia = registroAtualizado.materia;
       
            this.recuperacao = registroAtualizado.recuperacao;
            this.disciplina = registroAtualizado.disciplina;
            this.questoes = registroAtualizado.questoes;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'Nome' é obrigatório");

       

            if (materia == null)
                erros.Add("O campo 'Materia' é obrigatório");
            return erros.ToArray();
        }
    }
}
