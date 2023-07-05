using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private TabelaMateriaControl tabelaMateria;
        private IRepositorioMateria repositorioMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria)
        {
            this.repositorioMateria = repositorioMateria;
        }
        public override string ToolTipInserir { get { return "Inserir nova materia"; } }

        public override string ToolTipEditar { get { return "Editar materia existente"; } }

        public override string ToolTipExcluir { get { return "Excluir materia existente"; } }

        public override void Editar()
        {
            Materia Materia = ObterMateriaSelecionado();

            if (Materia == null)
            {
                MessageBox.Show($"Selecione uma materia primeiro!",
                    "Edição de materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
        }

        public override void Excluir()
        {
            Materia materia = ObterMateriaSelecionado();

            if (materia == null)
            {
                MessageBox.Show($"Selecione uma materia primeiro!",
                    "Exclusão de uma materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a materia {materia.nome}?", "Exclusão da materia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioMateria.Excluir(materia);
            }

            CarregarMateria();
        }

        public override void Inserir()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();

                repositorioMateria.Inserir(materia);
            }
            CarregarMateria();
        }
        private void CarregarMateria()
        {
            List<Materia> Materia = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(Materia);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMateria();

            return tabelaMateria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Materia";
        }
        private Materia ObterMateriaSelecionado()
        {
            int id = tabelaMateria.ObterIdSelecionado();

            return repositorioMateria.SelecionarPorId(id);
        }
    }
}
