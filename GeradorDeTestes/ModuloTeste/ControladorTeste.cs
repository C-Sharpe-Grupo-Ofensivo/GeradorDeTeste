using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioQuestao repositorioQuestao;
        private TabelaTesteControl tabelaTeste;
      
        

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }
        public override string ToolTipInserir => "Inserir novo Teste";

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => "Excluir Teste";

        public override bool EditarHabilitado => false;
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro!", "Exclução de teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o teste \"{testeSelecionado.nome}\"?", "Exclusão de teste",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                repositorioTeste.Excluir(testeSelecionado);
            }

            CarregarTeste();
        }
        //List<Materia> materia = repositorioMateria.SelecionarTodos();
        //List<Questao> questoes = repositorioQuestao.SelecionarTodos();
        //TelaQuestaoForm telaQuestao = new TelaQuestaoForm(materia, questoes);
        //telaQuestao.ConfigurarTela(new Questao());

        //    DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        Questao questao = telaQuestao.ObterQuestao();

        //repositorioQuestao.Inserir(questao);
        //    }

        //    else
        //        MessageBox.Show("Inserção Cancelada.");

        //    CarregarQuestoes();

    public override void Inserir()
        {
            List<Materia> materia = repositorioMateria.SelecionarTodos();
            List<Disciplina> disciplina = repositorioDisciplina.SelecionarTodos();
            List<Teste> teste1 = repositorioTeste.SelecionarTodos();
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();


            TelaTesteForm telaTeste = new TelaTesteForm(disciplina,materia, questoes, teste1);
            telaTeste.Text = "Cadastrar novo teste";

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();

                //_repositorioTeste.Inserir(teste);
                repositorioTeste.Inserir(teste);
            }

            CarregarTeste();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTeste();

            return tabelaTeste;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Teste";
        }

        private Teste ObterTesteSelecionado()
        {
            int id = tabelaTeste.ObterIdSelecionado();
            return repositorioTeste.SelecionarPorId(id);
        }

        private void CarregarTeste()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            tabelaTeste.AtualizarRegistros(testes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} testes");
        }

        //public override void Listagem()
        //{
        //    Teste testeSelecionado = ObterTesteSelecionado();

        //    if (testeSelecionado == null)
        //    {
        //        MessageBox.Show("Selecione um teste primeiro!", "Listagem detalhes teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    TelaDetalhesForm telaDetalhes = new TelaDetalhesForm(this);
        //    telaDetalhes.Text = "Exibir detalhes do teste";

        //    telaDetalhes.ConfigurarTelaDetalhes(testeSelecionado);
        //    telaDetalhes.ShowDialog();
        //}
    }
}
