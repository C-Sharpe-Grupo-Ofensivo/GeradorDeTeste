﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
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

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaQuestãoForm : Form
    {
        private List<Questao> questoes;
        public TelaQuestãoForm(Questao questao)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(questao);
        }
        public void ObterMateria(List<Materia> materia)
        {
            foreach (Materia item in materia)
            {
                
            }
        }
        public Questao ObterQuestao()
        {
            int id = Convert.ToInt32(txtId.Text);

            string enunciado = txtEnunciado.Text;
            string resposta = chkAlternativa.CheckedItems.ToString();
            List<Alternativa> alternativa = new List<Alternativa>();
            alternativa.AddRange(chkAlternativa.Items.Cast<Alternativa>());

            Questao questao = new Questao(enunciado, resposta, alternativa);

            if (id > 0)
                questao.id = id;

            return questao;
        }
        public void ConfigurarTela(Questao questao)
        {
            txtId.Text = questao.id.ToString();

            chkAlternativa.Text = questao.resposta;
            txtEnunciado.Text = questao.enunciado;

            foreach (Alternativa item in questao.alternativa)
            {
                chkAlternativa.Items.Add(item);
            }

        }
        private void btnGravar_Click(object sender, EventArgs e, Questao questao)
        {
            questao = ObterQuestao();

            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                //TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Alternativa alternativa = new Alternativa();

            alternativa.alternativa = txtResposta.Text;

            chkAlternativa.Items.Add(alternativa);

            txtResposta.Text = "";
        }
    }
}