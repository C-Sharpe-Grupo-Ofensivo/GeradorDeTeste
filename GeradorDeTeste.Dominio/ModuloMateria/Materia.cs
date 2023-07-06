using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public Disciplina disciplina { get; set; }
        public string nome { get; set; }


        
        public Materia(int id, string nome, Disciplina disciplina) : this()
        {
            
            this.id = id;
            this.nome = nome;
            this.disciplina = disciplina;
        }

        public Materia(string nome)
        {
            this.nome = nome;
        }

        public Materia()
        {
        }


        public override void AtualizarInformacoes(Materia registroAtualizado)
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
            return obj is Materia materia &&
                   id == materia.id &&
                   nome == materia.nome;

        }
    }
}
