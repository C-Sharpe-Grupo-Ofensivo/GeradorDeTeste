using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private IRepositorioMateria repositorioMateria;
        private List<Teste> teste;
        private List<Questao> questao;
        private bool duplicar;
        public TelaTesteForm(List<Disciplina> disciplina, List<Materia> materia, List<Questao> questao, List<Teste> teste)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            ObterDisciplina(disciplina);
            ObterMateria(materia);
            this.questao = questao;
            this.teste = teste;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void ObterMateria(List<Materia> materia)
        {
            foreach (Materia item in materia)
            {
                cmbMateria.Items.Add(item);
            }
        }



        public void ObterDisciplina(List<Disciplina> disciplina)
        {
            foreach (Disciplina item in disciplina)
            {
                cmbDisciplina.Items.Add(item);
            }
        }

        public List<Questao> ObterQuestaoSorteada()
        {
            return listQuestao.Items.Cast<Questao>().ToList();
        }

        public void ConfigurarTela(Teste teste)
        {
            txtId.Text = teste.id.ToString();
            txtNome.Text = teste.nome;

            cmbDisciplina.Text = teste.disciplina.ToString();
            cmbMateria.Text = teste.materia.ToString();
            ckRecuperacao.Checked = teste.recuperacao;

            //Materia materia = cmbMateria.SelectedItem as Materia;



        }


        public Teste ObterTeste()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbDisciplina.SelectedItem;

            bool recuperacao = ckRecuperacao.Checked;
     

            Teste teste = new Teste(id, nome, materia, recuperacao, disciplina, questao);
            teste.id = id;

            return teste;
        }





        private void btnSortear_Click(object sender, EventArgs e)
        {

            if (cmbMateria.SelectedItem != null)
            {
                Materia materiaSelecionada = (Materia)cmbMateria.SelectedItem;


                List<Questao> questoesSorteadas = SortearQuestoes(questao);

                foreach (Questao item in questoesSorteadas)
                {
                    listQuestao.Items.Add(item);
                }

            }
        }

        private List<Questao> SortearQuestoes(List<Questao> questao)
        {
            List<Questao> questoesSorteadas = new List<Questao>();
            Random random = new Random();
            Materia materia = (Materia)cmbMateria.SelectedItem;

            List<Questao> questoesFiltradas = questao.FindAll(x => x.materia.id == materia.id);

            for (int i = 0; i < questoesFiltradas.Count; i++)
            {
                if (questoesFiltradas.Count == 0)
                    break;

                int index = random.Next(questoesFiltradas.Count);
                questoesSorteadas.Add(questoesFiltradas[index]);
                questoesFiltradas.RemoveAt(index);
            }

            return questoesSorteadas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();

            string[] erros = teste.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }



        }
    }
}
