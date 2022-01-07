using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Client
{
    public partial class Form1 : Form
    {
        private readonly ITokenPriceOrchestrator? _moralisBalanceOrchestrator;
        private Returned _returned;
        private WalletDto _walletDtoOrigin;
        private WalletDto _walletDtoDestination;
        private TokenDto _tokenDtoOrigin;
        private TokenDto _tokenDtoDestination;

        private void InicializeWalletDto(WalletDto walletDto)
        {
            if (walletDto == null)
                walletDto = new WalletDto();
        }

        private void InicializeTokenDto(TokenDto tokenDto)
        {
            if (tokenDto == null)
                tokenDto = new TokenDto();
        }

        private void InicializeReturned(Returned returned)
        {
            if (returned == null)
            {
                returned = ReturnedExtension.CreateReturned();

                ReturnedState.NewReturnedMessage += new NewReturnedMessageEventHandler(NewMessage);
            }
        }

        private void InicializeObjects()
        {
            InicializeTokenDto(_tokenDtoOrigin);
            InicializeTokenDto(_tokenDtoDestination);
            InicializeWalletDto(_walletDtoOrigin);
            InicializeWalletDto(_walletDtoDestination);
            InicializeReturned(_returned);
        }

        private void FillObjectsFromForm()
        {
            _walletDtoOrigin.Adress = walletAdressOrigem.Text;

            _walletDtoDestination.Adress = walletAdressDestino.Text;

            _tokenDtoOrigin.Adress = tokenAdressOrigem.Text;

            _tokenDtoDestination.Adress = tokenAdressDestino.Text;
        }

        public Form1()
        {
            _moralisBalanceOrchestrator = Program.ServiceProvider?.GetService(typeof(ITokenPriceOrchestrator)) as ITokenPriceOrchestrator;
            InitializeComponent();
            InicializeObjects();
        }

        private void NewMessage(object source, EventArgs e)
        {
            ReturnedState returnedState = (ReturnedState)source;

#if !DEBUG
                if !(returnedState.MessageToRelease)
                    return;
#endif

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
            FillObjectsFromForm();

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

            _returned.ReturnedState.Message = "Form - Inicio";

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

            _returned.ReturnedState.Message = "Form - Fim";
        }

        private async void btnTransferirParaDestino_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            _returned.ReturnedState.Message = "Form - Inicio";

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
            _returned.ReturnedState.Message = "Form - Fim";
        }
    }
}