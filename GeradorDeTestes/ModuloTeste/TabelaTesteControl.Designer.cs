namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TabelaTesteControl
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
            gridTeste = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTeste).BeginInit();
            SuspendLayout();
            // 
            // gridTeste
            // 
            gridTeste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTeste.Dock = DockStyle.Fill;
            gridTeste.Location = new Point(0, 0);
            gridTeste.Name = "gridTeste";
            gridTeste.RowTemplate.Height = 25;
            gridTeste.Size = new Size(150, 150);
            gridTeste.TabIndex = 0;
            // 
            // TabelaTesteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTeste);
            Name = "TabelaTesteControl";
            ((System.ComponentModel.ISupportInitialize)gridTeste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTeste;
    }
}
