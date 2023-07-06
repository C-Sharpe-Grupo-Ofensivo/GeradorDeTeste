using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaQuestãoForm : Form
    {
        public TelaQuestãoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Questao ObterQuestao()
        {
            //int id = Convert.ToInt32(txtId.Text);

            string enunciado = txtEnunciado.Text;
            string resposta = txtResposta.Text;
            string alternativa = "x";

            Questao questao = new Questao(resposta, enunciado, alternativa);

            //if (id > 0)
            //    disciplina.id = id;

            return questao;
        }
        public void ConfigurarTela(Questao questao)
        {
            //txtId.Text = questao.id.ToString();

            txtResposta.Text = questao.resposta;
            txtEnunciado.Text = questao.resposta;


        }
        private void btnGravar_Click(object sender, EventArgs e, Questao questao)
        {
            questao = ObterQuestao();

            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                //TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
    }
}