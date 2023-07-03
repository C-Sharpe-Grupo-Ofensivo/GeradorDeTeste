namespace GeradorDeTestes
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        public static object Instancia { get; internal set; }
    }
}