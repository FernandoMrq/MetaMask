using MRQ.CryptoBot.Domain.Adapter.Moralis;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Client
{
    public partial class Form1 : Form
    {
        private readonly Returned _returned;
        private readonly ITokenPriceOrchestrator? _moralisBalanceOrchestrator;
        private readonly WalletDto _walletDtoOrigin;
        private readonly WalletDto _walletDtoDestination;
        private readonly TokenDto _tokenDtoOrigin;
        private readonly TokenDto _tokenDtoDestination;

        public Form1()
        {
            _moralisBalanceOrchestrator = Program.ServiceProvider?.GetService(typeof(ITokenPriceOrchestrator)) as ITokenPriceOrchestrator;

            _walletDtoOrigin = new WalletDto();
            _walletDtoDestination = new WalletDto();

            _tokenDtoOrigin = new TokenDto();
            _tokenDtoDestination = new TokenDto();

            _returned = ReturnedExtension.CreateReturned();

            InicializeReturned();
            InitializeComponent();
        }

        /*
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

        
        private void InicializeObjects()
        {
            InicializeTokenDto(_tokenDtoOrigin);
            InicializeTokenDto(_tokenDtoDestination);
            InicializeWalletDto(_walletDtoOrigin);
            InicializeWalletDto(_walletDtoDestination);
            InicializeReturned(_returned);
        }

        */

        private void InicializeReturned()
        {
            ReturnedState.NewReturnedMessage += new NewReturnedMessageEventHandler(NewMessage);
        }

        private void FillObjectsFromForm()
        {
            _walletDtoOrigin.Adress = walletAdressOrigem.Text;
            _walletDtoOrigin.PrivateKey = privateKeyOrigem.Text;

            _walletDtoDestination.Adress = walletAdressDestino.Text;

            _tokenDtoOrigin.Adress = tokenAdressOrigem.Text;

            _tokenDtoDestination.Adress = tokenAdressDestino.Text;
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
            FillObjectsFromForm();

            PriceOfTokenDto retorno;

            if (_moralisBalanceOrchestrator is null)
                return;

            if (_tokenDtoOrigin.Adress is null)
                return;

            retorno = (PriceOfTokenDto)(await _moralisBalanceOrchestrator.GetTokenPrice(_tokenDtoOrigin)).Object;

            await _moralisBalanceOrchestrator.GetWalletBalanceDefault(_walletDtoOrigin);
            await _moralisBalanceOrchestrator.GetWalletBalance(_walletDtoOrigin);
            await _moralisBalanceOrchestrator.GetTransactionDetails("0x34a234638b0cbf184b6985cf0db2ac3a5b6522b6c9636a746a651c727fb219ab");

            valorToken.Text = retorno.UsdPrice.ToString();
        }

        private async void btnBalance_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            if (_moralisBalanceOrchestrator is null)
                return;

            await _moralisBalanceOrchestrator.GetWalletBalanceOfToken(_walletDtoOrigin, _tokenDtoOrigin);

            balance.Text = _tokenDtoOrigin.Name + " : " + _tokenDtoOrigin.Balance;
        }

        private async void btnSwapTokens_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            await _moralisBalanceOrchestrator?.SwapTokensAsync(_walletDtoOrigin, _tokenDtoOrigin, _tokenDtoDestination);

            ReturnedExtension.InsertLogMessage(_returned, "Form - Fim");
        }

        private async void btnTransferirParaDestino_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            ReturnedExtension.InsertLogMessage(_returned, "Form - Inicio");

            await _moralisBalanceOrchestrator?.SendToWalletAsync(_walletDtoOrigin, _walletDtoDestination, _tokenDtoOrigin);

            ReturnedExtension.InsertLogMessage(_returned, "Form - Fim");
        }
    }
}