using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Inserir(Disciplina novaDisciplina);
        void Editar(int id, Disciplina disciplina);
        void Excluir(Disciplina DisciplinaSelecionada);
        List<Disciplina> SelecionarTodos();
        Disciplina SelecionarPorId(int id);
    }
}
