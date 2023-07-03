using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();

            gridDisciplinas.ConfigurarGridZebrado();

            gridDisciplinas.ConfigurarGridSomenteLeitura();
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
                    HeaderText = "Nome"
                },

            };

            gridDisciplinas.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            gridDisciplinas.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                gridDisciplinas.Rows.Add(disciplina.id, disciplina.nome);
            }
        }
        public int ObterIdSelecionado()
        {
            if (gridDisciplinas.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridDisciplinas.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
