using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Client
{
    public partial class Form1 : Form
    {
        private readonly ITokenPriceOrchestrator? _moralisBalanceOrchestrator;
        private Returned _returned;

        public Form1()
        {
            _moralisBalanceOrchestrator = Program.ServiceProvider?.GetService(typeof(ITokenPriceOrchestrator)) as ITokenPriceOrchestrator;
            InitializeComponent();

            _returned = ReturnedExtension.CreateReturned();

            ReturnedState.NewReturnedMessage += new NewReturnedMessageEventHandler(NewMessage);
        }

        private void NewMessage(object source, EventArgs e)
        {
            ReturnedState returnedState = (ReturnedState)source;

            consoleMessage.Text += string.Concat(Environment.NewLine, returnedState.Message);
        }

        private async void btnTokenPrice_ClickAsync(object sender, EventArgs e)
        {
            consoleMessage.Clear();

            var retorno = await _moralisBalanceOrchestrator?.GetTokenPrice(tokenAdressOrigem.Text);

            valorToken.Text = retorno.UsdPrice.ToString();
        }

        private async void btnBalance_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();

            WalletDto wallet = new WalletDto
            {
                Adress = walletAdressOrigem.Text,
                Tokens = new List<TokenDto>
                {
                    new TokenDto
                    {
                        Adress = tokenAdressOrigem.Text
                    }
                }
            };

            await _moralisBalanceOrchestrator?.GetWalletBalanceOfToken(wallet);

            balance.Text = wallet.Tokens.FirstOrDefault().Name + " : " + wallet.Tokens.FirstOrDefault().Balance;
        }

        private async void btnSwapTokens_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();

            _returned.ReturnedState.Message = String.Concat("Inicio: ", DateTime.Now.ToString("hh.mm.ss.ffffff"));

            WalletDto wallet = new WalletDto
            {
                Adress = walletAdressOrigem.Text,
                Tokens = new List<TokenDto>
                {
                    new TokenDto
                    {
                        Adress = tokenAdressOrigem.Text
                    }
                },
                PrivateKey = privateKeyOrigem.Text
            };

            TokenDto tokenDtoOrigem = new TokenDto
            {
                Adress = tokenAdressOrigem.Text,
                Balance = decimal.Parse(quantidadeOrigem.Text)
            };

            TokenDto tokenDestino = new TokenDto
            {
                Adress = tokenAdressDestino.Text
            };

            await _moralisBalanceOrchestrator?.SwapTokensAsync(wallet, tokenDtoOrigem, tokenDestino);
        }

        private async void btnTransferirParaDestino_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();

            WalletDto walletOrigem = new WalletDto
            {
                Adress = walletAdressOrigem.Text,
                Tokens = new List<TokenDto>
                {
                    new TokenDto
                    {
                        Adress = tokenAdressOrigem.Text
                    }
                }
            };

            WalletDto walletDestino = new WalletDto
            {
                Adress = walletAdressDestino.Text
            };

            TokenDto tokenDtoOrigem = new TokenDto
            {
                Adress = tokenAdressOrigem.Text,
                Balance = decimal.Parse(quantidadeOrigem.Text)
            };

            await _moralisBalanceOrchestrator?.SendToWalletAsync(walletOrigem, walletDestino, tokenDtoOrigem);
        }
    }
}