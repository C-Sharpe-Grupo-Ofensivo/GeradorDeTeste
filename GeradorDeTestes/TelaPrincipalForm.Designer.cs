﻿namespace GeradorDeTestes
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRegistros = new Panel();
            barraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            labelTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasMenuItem = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            barraFerramentas.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 93);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(761, 303);
            panelRegistros.TabIndex = 7;
            // 
            // barraFerramentas
            // 
            barraFerramentas.Enabled = false;
            barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, labelTipoCadastro });
            barraFerramentas.Location = new Point(0, 24);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(761, 69);
            barraFerramentas.TabIndex = 6;
            barraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = WinApp.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz48_1_;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(66, 66);
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = WinApp.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(66, 66);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = WinApp.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(66, 66);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(75, 66);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 396);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(761, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodape]";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(761, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(125, 22);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click_1;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(125, 22);
            compromissosMenuItem.Text = "Materia";
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(125, 22);
            tarefasMenuItem.Text = "Questoes";
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem, categoriasMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(125, 22);
            despesasToolStripMenuItem.Text = "Testes";
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.Name = "despesasMenuItem";
            despesasMenuItem.Size = new Size(130, 22);
            despesasMenuItem.Text = "Despesas";
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(130, 22);
            categoriasMenuItem.Text = "Categorias";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(95, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios PDF";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 418);
            Controls.Add(panelRegistros);
            Controls.Add(barraFerramentas);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "TelaPrincipalForm";
            Text = "Form1";
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRegistros;
        private ToolStrip barraFerramentas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripLabel labelTipoCadastro;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}