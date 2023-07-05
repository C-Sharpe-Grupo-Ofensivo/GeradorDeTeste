using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public interface IRepositorioMateria
    {
        void Inserir(Materia novaMateria);
        void Editar(int id, Materia materia);
        void Excluir(Materia MateriaSelecionada);
        List<Materia> SelecionarTodos();
        Materia SelecionarPorId(int id);
    }
}
