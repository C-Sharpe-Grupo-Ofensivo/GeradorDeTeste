namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaTesteForm
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
            txtId = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            panel1 = new Panel();
            listQuestao = new ListBox();
            btnSortear = new Button();
            btnRemover = new Button();
            label4 = new Label();
            label1 = new Label();
            cmbDisciplina = new ComboBox();
            label2 = new Label();
            label444 = new Label();
            ckRecuperacao = new CheckBox();
            cmbMateria = new ComboBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(31, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 23;
            txtId.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 13);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 22;
            label5.Text = "ID:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(330, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 33);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.None;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(236, 396);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 33);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(listQuestao);
            panel1.Controls.Add(btnSortear);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(18, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 239);
            panel1.TabIndex = 15;
            // 
            // listQuestao
            // 
            listQuestao.FormattingEnabled = true;
            listQuestao.ItemHeight = 15;
            listQuestao.Location = new Point(0, 42);
            listQuestao.Name = "listQuestao";
            listQuestao.Size = new Size(395, 199);
            listQuestao.TabIndex = 8;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(135, 13);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(134, 23);
            btnSortear.TabIndex = 7;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.None;
            btnRemover.Location = new Point(404, 69);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(88, 26);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Questões:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(104, 8);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome:";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.Anchor = AnchorStyles.None;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(71, 44);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(265, 23);
            cmbDisciplina.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(14, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 24;
            label2.Text = "Disciplina:";
            // 
            // label444
            // 
            label444.Anchor = AnchorStyles.None;
            label444.AutoSize = true;
            label444.Location = new Point(15, 90);
            label444.Name = "label444";
            label444.Size = new Size(50, 15);
            label444.TabIndex = 26;
            label444.Text = "Matéria:";
            // 
            // ckRecuperacao
            // 
            ckRecuperacao.AutoSize = true;
            ckRecuperacao.Location = new Point(342, 89);
            ckRecuperacao.Name = "ckRecuperacao";
            ckRecuperacao.Size = new Size(94, 19);
            ckRecuperacao.TabIndex = 28;
            ckRecuperacao.Text = "Recuperação";
            ckRecuperacao.UseVisualStyleBackColor = true;
            ckRecuperacao.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.Anchor = AnchorStyles.None;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(71, 85);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(265, 23);
            cmbMateria.TabIndex = 29;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(153, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 23);
            txtNome.TabIndex = 30;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 441);
            Controls.Add(txtNome);
            Controls.Add(cmbMateria);
            Controls.Add(ckRecuperacao);
            Controls.Add(label444);
            Controls.Add(cmbDisciplina);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "TelaTesteForm";
            Text = "TelaTesteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label5;
        private Button btnCancelar;
        private Button btnGravar;
        private Panel panel1;
        private CheckedListBox chkAlternativa;
        private Button btnRemover;
        private Label label4;
        private Label label1;
        private ComboBox cmbDisciplina;
        private Label label2;
        private ComboBox comboBox2;
        private Label label444;
        private CheckBox ckRecuperacao;
        private ListBox listQuestao;
        private Button btnSortear;
        private ComboBox cmbMateria;
        private TextBox txtNome;
    }
}