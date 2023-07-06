using GeradorDeTestes.Dominio.ModuloMateria;
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
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            ConfigurarColunas();

            gridQuestao.ConfigurarGridZebrado();

            gridQuestao.ConfigurarGridSomenteLeitura();
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
                    Name = "materia",
                    HeaderText = "Materia"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "enunciado",
                    HeaderText = "Enunciado"
                },
            };

            gridQuestao.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Questao> questoes)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao questao in questoes)
            {
                gridQuestao.Rows.Add(questao.id, questao.materia, questao.enunciado);
            }
        }
        public int ObterIdSelecionado()
        {
            if (gridQuestao.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridQuestao.SelectedRows[0].Cells["id"].Value);

            return id;

        }
    }
}
