namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaPDFForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDiretorio = new TextBox();
            label2 = new Label();
            btnDiretorio = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(106, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(189, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Titulo de Teste:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(71, 62);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(189, 23);
            txtDiretorio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Diretorio:";
            // 
            // btnDiretorio
            // 
            btnDiretorio.Location = new Point(273, 61);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(75, 23);
            btnDiretorio.TabIndex = 5;
            btnDiretorio.Text = "Localizar";
            btnDiretorio.UseVisualStyleBackColor = true;
            btnDiretorio.Click += btnDiretorio_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 174);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Gerar PDF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(220, 174);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // TelaPDFForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 222);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnDiretorio);
            Controls.Add(label2);
            Controls.Add(txtDiretorio);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "TelaPDFForm";
            Text = "TelaPDFForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDiretorio;
        private Label label2;
        private Button btnDiretorio;
        private Button button2;
        private Button button3;
    }
}