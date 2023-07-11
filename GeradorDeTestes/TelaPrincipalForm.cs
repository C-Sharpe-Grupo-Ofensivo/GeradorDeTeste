using GeradorDeTeste.Infra.Sql.ModuloDisciplina;
using GeradorDeTeste.Infra.Sql.ModuloMateria;
using GeradorDeTeste.Infra.Sql.ModuloQuestao;
using GeradorDeTeste.Infra.Sql.ModuloTeste;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloTeste;

namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;



        private static TelaPrincipalForm telaPrincipal;

        private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmSql();
        private IRepositorioMateria repositorioMateria = new RepositorioMateriaEmSql();
        private IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoEmSql();
        private IRepositorioTeste repositorioTeste = new RepositorioTesteEmSql();


        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            barraFerramentas.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarEstados(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;

        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }


        private void disciplinaMenuItem_Click_1(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestoes(repositorioQuestao, repositorioMateria);
            ConfigurarTelaPrincipal(controlador);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioTeste, repositorioDisciplina, repositorioQuestao, repositorioMateria);
            ConfigurarTelaPrincipal(controlador);
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador.PDF();
        }
    }
}