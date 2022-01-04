using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Orchestrator;

namespace MRQ.CryptoBot.Client
{
    public partial class Form1 : Form
    {
        private readonly IMoralisBalanceOrchestrator? _moralisBalanceOrchestrator;

        public Form1()
        {
            _moralisBalanceOrchestrator = Program.ServiceProvider?.GetService(typeof(IMoralisBalanceOrchestrator)) as IMoralisBalanceOrchestrator;
            InitializeComponent();
        }

        private void iniciaChrome_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var retorno = await _moralisBalanceOrchestrator?.GetTokenBalance(tokenAdress.Text);

            valorToken.Text = retorno.UsdPrice.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            WalletDto wallet = new WalletDto
            {
                Adress = walletadress.Text,
                Tokens = new List<TokenDto>
                {
                    new TokenDto
                    {
                        Adress = tokenAdress.Text
                    }
                }
            };

            await _moralisBalanceOrchestrator?.GetBalanceOfToken(wallet);

            balance.Text = wallet.Tokens.FirstOrDefault().Name + " : " + wallet.Tokens.FirstOrDefault().BalanceBNB;
        }
    }
}