namespace GeradorDeTestes.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            Id = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            cbDisciplina = new ComboBox();
            rbdPrimeiraSerie = new RadioButton();
            rdbSegundaSerie = new RadioButton();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(63, 39);
            Id.Name = "Id";
            Id.Size = new Size(20, 15);
            Id.TabIndex = 0;
            Id.Text = "Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 74);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 145);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Série:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(307, 210);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(83, 53);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(430, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 53);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(89, 31);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(89, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(429, 23);
            txtNome.TabIndex = 9;
            // 
            // cbDisciplina
            // 
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(91, 107);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(98, 23);
            cbDisciplina.TabIndex = 10;
            // 
            // rbdPrimeiraSerie
            // 
            rbdPrimeiraSerie.AutoSize = true;
            rbdPrimeiraSerie.Location = new Point(95, 145);
            rbdPrimeiraSerie.Name = "rbdPrimeiraSerie";
            rbdPrimeiraSerie.Size = new Size(36, 19);
            rbdPrimeiraSerie.TabIndex = 11;
            rbdPrimeiraSerie.TabStop = true;
            rbdPrimeiraSerie.Text = "1ª";
            rbdPrimeiraSerie.UseVisualStyleBackColor = true;
            // 
            // rdbSegundaSerie
            // 
            rdbSegundaSerie.AutoSize = true;
            rdbSegundaSerie.Location = new Point(137, 145);
            rdbSegundaSerie.Name = "rdbSegundaSerie";
            rdbSegundaSerie.Size = new Size(36, 19);
            rdbSegundaSerie.TabIndex = 12;
            rdbSegundaSerie.TabStop = true;
            rdbSegundaSerie.Text = "2ª";
            rdbSegundaSerie.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 296);
            Controls.Add(rdbSegundaSerie);
            Controls.Add(rbdPrimeiraSerie);
            Controls.Add(cbDisciplina);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            Text = "TelaMateriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtNome;
        private ComboBox cbDisciplina;
        private RadioButton rbdPrimeiraSerie;
        private RadioButton rdbSegundaSerie;
    }
}