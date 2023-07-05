namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridDisciplinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // gridDisciplinas
            // 
            gridDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDisciplinas.Dock = DockStyle.Fill;
            gridDisciplinas.Location = new Point(0, 0);
            gridDisciplinas.Name = "gridDisciplinas";
            gridDisciplinas.RowTemplate.Height = 25;
            gridDisciplinas.Size = new Size(150, 150);
            gridDisciplinas.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridDisciplinas);
            Name = "TabelaDisciplinaControl";
            ((System.ComponentModel.ISupportInitialize)gridDisciplinas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridDisciplinas;
    }
}
