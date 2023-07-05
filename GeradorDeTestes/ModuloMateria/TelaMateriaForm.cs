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
        public TelaMateriaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Materia ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;


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
            Materia Materia = ObterDisciplina();

            string[] erros = Materia.Validar();

            if (erros.Length > 0)
            {
                //TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
