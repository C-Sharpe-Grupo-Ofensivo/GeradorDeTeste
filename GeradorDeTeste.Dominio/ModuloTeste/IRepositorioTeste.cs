using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste
    {
        void Inserir(Teste novoTeste);
        void Editar(int id, Teste teste);
        void Excluir(Teste TesteSelecionada);
        List<Teste> SelecionarTodos();
        Teste SelecionarPorId(int id);
    }
}
