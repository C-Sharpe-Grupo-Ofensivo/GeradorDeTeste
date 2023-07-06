using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class ControladorQuestoes : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioMateria repositorioMateria;

        public ControladorQuestoes(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
        }
        public override string ToolTipInserir => "Inserir nova Questão";

        public override string ToolTipEditar => "Editar Questão";

        public override string ToolTipExcluir => "Excluir Questão";

        public override void Inserir()
        {
            List<Materia> materia = repositorioMateria.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(materia, questoes);
            telaQuestao.ConfigurarTela(new Questao());

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                repositorioQuestao.Inserir(questao);
            }

            else
                MessageBox.Show("Inserção Cancelada.");

            CarregarQuestoes();
        }

        public override void Editar()
        {
            Questao questaoselecionada = ObterQuestaoSelecionado();

            if (questaoselecionada == null)
            {
                MessageBox.Show($"Selecione uma Questão primeiro!",
                    "Edição de Questões",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            telaQuestao.ConfigurarTela(questaoselecionada);

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                repositorioQuestao.Editar(questao.id, questao);
            }

            else
                MessageBox.Show("Edição Cancelada.");
            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questao = ObterQuestaoSelecionado();

            if (questao  == null)
            {
                MessageBox.Show($"Selecione uma Questão primeiro!",
                    "Exclusão de Questões",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Questão {questao.id}?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questao);
            }

            else
                MessageBox.Show("Exclusão Cancelada.");

            CarregarQuestoes();
        }

        private Questao ObterQuestaoSelecionado()
        {
            int id = tabelaQuestao.ObterIdSelecionado();

            return repositorioQuestao.SelecionarPorId(id);
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Questões";
        }
    }
}