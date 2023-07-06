using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao
    {
        void Inserir(Questao novaQuestao);
        void Editar(int id, Questao questao);
        void Excluir(Questao QuestaoSelecionada);
        List<Questao> SelecionarTodos();
        Questao SelecionarPorId(int id);
    }
}
