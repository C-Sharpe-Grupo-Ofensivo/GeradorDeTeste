using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaPDFForm : Form
    {
        private Teste teste;
        private IRepositorioQuestao repositorioQuestao;

        public TelaPDFForm(Teste teste, IRepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.teste = teste;
            this.repositorioQuestao = repositorioQuestao;
        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = fbd.SelectedPath;
            }

            DialogResult = DialogResult.None;
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Escolha um diretório para guardar seu PDF");
                DialogResult = DialogResult.None;
                return false;
            }

          

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                EscreverPdf();
                MessageBox.Show($"PDF gerado com sucesso! Confira no caminho: \n{txtDiretorio.Text}");
            }

        }

        private void EscreverPdf()
        {
           

            string caminho = Path.Combine(txtDiretorio.Text + ".pdf");

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 30, 30, 30, 30);
            FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            //-------------------------------------------------------------------------------------------------------------------------------------------
            doc.Open();

            BaseColor corPadrao = BaseColor.BLACK;
            BaseColor corGabarito = new BaseColor(34, 139, 34);

            iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, corPadrao);
            iTextSharp.text.Font fonteInfo = FontFactory.GetFont(FontFactory.HELVETICA, 13, corPadrao);
            iTextSharp.text.Font fonteQuestao = FontFactory.GetFont(FontFactory.HELVETICA, 12, corPadrao);
            iTextSharp.text.Font fonteGabarito = FontFactory.GetFont(FontFactory.HELVETICA, 12, corGabarito);

            Paragraph data = new Paragraph(string.Format($"Data: {DateTime.Today.ToString("dd/MM/yyyy")}"), fonteInfo);
            doc.Add(data);

            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                Paragraph nomeTeste = new Paragraph(string.Format($"Nome: {txtNome.Text}"), fonteInfo);
                doc.Add(nomeTeste);
            }

            Paragraph disciplina = new Paragraph(string.Format($"Disciplina: {teste.disciplina}"), fonteInfo);
            doc.Add(disciplina);

            Paragraph materia = new Paragraph(string.Format($"Matéria: {teste.materia}"), fonteInfo);
            doc.Add(materia);

            if (teste.recuperacao)
            {
                Paragraph recuperacao = new Paragraph(string.Format($"Prova de recuperação"), fonteInfo);
                doc.Add(recuperacao);
            }

            doc.Add(new Paragraph(" "));

            Paragraph titulo = new Paragraph(string.Format($"{teste.nome.ToUpper()}"), fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));

            teste.questoes.ForEach(q =>
            {
                char letra = 'A';
                repositorioQuestao.SelecionarTodos();

                Paragraph questao = new Paragraph(string.Format($"{q}"), fonteQuestao);
                doc.Add(questao);
                doc.Add(new Paragraph(" "));

                q.alternativas.ForEach(a =>
                {
                    Paragraph alternativa = new Paragraph(string.Format($"{letra}) {a}"), fonteQuestao);
                    doc.Add(alternativa);
                    doc.Add(new Paragraph(""));
                    letra++;
                });

                

                doc.Add(new Paragraph(" "));
            });

            doc.Close();
            //-------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
