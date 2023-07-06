using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        public TelaMateriaForm(List<Disciplina>disciplinas)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
        }
        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();
            foreach (Disciplina d in disciplinas)
            {
                cbDisciplina.Items.Add(d);
            }
        }
        public StatusSerieEnum ObterFiltroSerie()
        {
            if (rbdPrimeiraSerie.Checked == true)
                return StatusSerieEnum.Serie1;

            else if (rdbSegundaSerie.Checked == true)
                return StatusSerieEnum.Serie2;

            return StatusSerieEnum.Serie1;
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;

            Materia materia = new Materia(nome);

            if (id > 0)
                materia.id = id;

            return materia;
        }
        public void ConfigurarTela(Materia materia)
        {
            txtId.Text = materia.id.ToString();

            txtNome.Text = materia.nome;


        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materia Materia = ObterMateria();

            string[] erros = Materia.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
