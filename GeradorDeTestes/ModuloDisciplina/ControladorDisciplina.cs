using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplina;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override string ToolTipInserir { get { return "Inserir nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir disciplina existente"; } }

        public override void Editar()
        {
            Disciplina Disciplina = ObterDisciplinaSelecionado();

            if (Disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Edição de disciplina",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
        }

        public override void Excluir()
        {
            Disciplina disciplina = ObterDisciplinaSelecionado();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Exclusão de uma Disciplina",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina {disciplina.nome}?", "Exclusão da Disciplina",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplina);
            }

            CarregarDisciplina();
        }

        public override void Inserir()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos()); 

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();
                if (ValidarAtributos(disciplina))
                {
                    opcaoEscolhida = telaDisciplina.ShowDialog();
                    continue;
                }
                repositorioDisciplina.Inserir(disciplina);
                break;
            }
            


            CarregarDisciplina();
        }
        private void CarregarDisciplina()
        {
            List<Disciplina> Disciplina = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(Disciplina);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplina();

            return tabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Disciplina";
        }
        private Disciplina ObterDisciplinaSelecionado()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();

            return repositorioDisciplina.SelecionarPorId(id);
        }
        private bool ValidarAtributos(Disciplina disciplina)
        {
            if (repositorioDisciplina.SelecionarTodos().Any(m => m.nome == disciplina.nome))
            {
                MessageBox.Show($"Disciplina já cadastrada!", "Nova disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (disciplina.nome.Length < 3)
            {
                MessageBox.Show($"O nome da disciplina não pode ser menor que 3 caracteres!", "Nova Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }
    }
}
