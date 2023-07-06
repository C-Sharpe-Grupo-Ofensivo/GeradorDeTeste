namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaQuestãoForm
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
            checkedListBox1 = new CheckedListBox();
            button2 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            txtEnunciado = new TextBox();
            txtResposta = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Enunciado: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Resposta:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(14, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 231);
            panel1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(0, 32);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(385, 202);
            checkedListBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(297, 0);
            button2.Name = "button2";
            button2.Size = new Size(88, 26);
            button2.TabIndex = 5;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 4;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Anchor = AnchorStyles.None;
            txtEnunciado.Location = new Point(82, 51);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(317, 59);
            txtEnunciado.TabIndex = 5;
            // 
            // txtResposta
            // 
            txtResposta.Anchor = AnchorStyles.None;
            txtResposta.Location = new Point(82, 119);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(224, 23);
            txtResposta.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(311, 118);
            button1.Name = "button1";
            button1.Size = new Size(88, 24);
            button1.TabIndex = 7;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(227, 397);
            button3.Name = "button3";
            button3.Size = new Size(83, 38);
            button3.TabIndex = 8;
            button3.Text = "Gravar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(316, 397);
            button4.Name = "button4";
            button4.Size = new Size(83, 38);
            button4.TabIndex = 9;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // TelaQuestãoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 454);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestãoForm";
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
        private ComboBox comboBox1;
        private TextBox txtEnunciado;
        private TextBox txtResposta;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckedListBox checkedListBox1;
    }
}