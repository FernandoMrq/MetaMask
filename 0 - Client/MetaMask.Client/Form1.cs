using MetaMask.Domain.Orchestrator;

namespace MetaMask.Client
{
    public partial class Form1 : Form
    {
        private readonly IChromeOrchestrator _chromeOrchestrator;

        public Form1()
        {
            _chromeOrchestrator = Program.ServiceProvider.GetService(typeof(IChromeOrchestrator)) as IChromeOrchestrator;
            InitializeComponent();
        }

        private void iniciaChrome_Click(object sender, EventArgs e)
        {
            _chromeOrchestrator.ReturnChrome();
        }
    }
}