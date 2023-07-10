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
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridTeste.ConfigurarGridZebrado();

            gridTeste.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            gridTeste.Rows.Clear();

            foreach (Teste teste in testes)
            {
                gridTeste.Rows.Add(teste.id, teste.nome, teste.disciplina, teste.materia, teste.recuperacao);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} teste");
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Titulo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText = "Disciplina"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "Materia"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "recuperacao",
                    HeaderText = "Recuprecao"
                }

           };

            gridTeste.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridTeste.SelectedRows[0].Cells["ID"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
