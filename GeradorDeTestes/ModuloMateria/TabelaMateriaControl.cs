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
    public partial class TabelaMateriaControl : UserControl
    {

        public TabelaMateriaControl()
        {
            InitializeComponent();
            ConfigurarColunas();

            gridMateria.ConfigurarGridZebrado();

            gridMateria.ConfigurarGridSomenteLeitura();
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

            gridMateria.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            gridMateria.Rows.Clear();

            foreach (Materia materia in materias)
            {
                gridMateria.Rows.Add(materia.id, materia.nome);
            }
        }
        public int ObterIdSelecionado()
        {
            if (gridMateria.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridMateria.SelectedRows[0].Cells["id"].Value);

            return id;

        }
    }
}
