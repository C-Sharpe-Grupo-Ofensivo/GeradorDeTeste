using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string nome { get; set; }
        public Disciplina(int id, string nome) : this()
        {
            this.id = id;
            this.nome = nome;
            
        }

        public Disciplina(string nome)
        {
            this.nome = nome;
        }

        public Disciplina()
        {
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
        }
        public override string ToString()
        {
            return $"{nome}";
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'Nome' é obrigatório");

            return erros.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Disciplina disciplina &&
                   id == disciplina.id &&
                   nome == disciplina.nome;
                   
        }
    }
}
