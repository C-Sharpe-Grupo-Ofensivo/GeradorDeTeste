namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            chkAlternativa = new CheckedListBox();
            btnRemover = new Button();
            label4 = new Label();
            cmbMateria = new ComboBox();
            txtEnunciado = new TextBox();
            txtResposta = new TextBox();
            btnAdicionar = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(90, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(7, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Enunciado: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(9, 135);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Resposta:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(chkAlternativa);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(9, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 226);
            panel1.TabIndex = 3;
            // 
            // chkAlternativa
            // 
            chkAlternativa.FormattingEnabled = true;
            chkAlternativa.Location = new Point(0, 41);
            chkAlternativa.Name = "chkAlternativa";
            chkAlternativa.Size = new Size(395, 184);
            chkAlternativa.TabIndex = 6;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.None;
            btnRemover.Location = new Point(307, 0);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(88, 26);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Alternativas:";
            // 
            // cmbMateria
            // 
            cmbMateria.Anchor = AnchorStyles.None;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(139, 12);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(265, 23);
            cmbMateria.TabIndex = 4;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Anchor = AnchorStyles.None;
            txtEnunciado.Location = new Point(82, 62);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(322, 54);
            txtEnunciado.TabIndex = 5;
            // 
            // txtResposta
            // 
            txtResposta.Anchor = AnchorStyles.None;
            txtResposta.Location = new Point(82, 135);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(229, 23);
            txtResposta.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.None;
            btnAdicionar.Location = new Point(311, 134);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(93, 24);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.None;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(227, 410);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 33);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(316, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 33);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 15);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 10;
            label5.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            txtId.TextChanged += txtId_TextChanged;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 455);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(cmbMateria);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Questões";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private ComboBox cmbMateria;
        private TextBox txtEnunciado;
        private TextBox txtResposta;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnGravar;
        private Button btnCancelar;
        private CheckedListBox chkAlternativa;
        private Label label5;
        private TextBox txtId;
    }
}