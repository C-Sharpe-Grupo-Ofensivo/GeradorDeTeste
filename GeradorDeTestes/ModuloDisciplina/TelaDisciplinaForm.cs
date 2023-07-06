using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        public TelaDisciplinaForm(List<Disciplina>disciplinas)
        {
            InitializeComponent();
            this.ConfigurarDialog();

        }

        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;


            Disciplina disciplina = new Disciplina(id, nome);

            if (id > 0)
                disciplina.id = id;

            return disciplina;
        }
        public void ConfigurarTela(Disciplina disciplina)
        {
            txtId.Text = disciplina.id.ToString();

            txtNome.Text = disciplina.nome;


        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
