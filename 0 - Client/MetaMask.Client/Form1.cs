using MRQ.CryptoBot.Client.Interfaces;
using MRQ.CryptoBot.Domains.Adapter.Moralis;
using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domains.Application;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Client
{
    public partial class Form1 : Form
    {
        private readonly Returned _returned;
        private readonly ITokenPriceApplication? _moralisBalanceApplication;
        private readonly WalletDto _walletDtoOrigin;
        private readonly WalletDto _walletDtoDestination;
        private readonly TokenDto _tokenDtoOrigin;
        private readonly TokenDto _tokenDtoDestination;
        private readonly ConfigurationInterface _configurationInterface;

        public Form1()
        {
            _moralisBalanceApplication = Program.ServiceProvider?.GetService(typeof(ITokenPriceApplication)) as ITokenPriceApplication;
            //var databaseBusiness = Program.ServiceProvider?.GetService(typeof(IDatabaseBusiness)) as IDatabaseBusiness;

            _walletDtoOrigin = new WalletDto();
            _walletDtoDestination = new WalletDto();

            _tokenDtoOrigin = new TokenDto();
            _tokenDtoDestination = new TokenDto();

            _returned = ReturnedExtension.CreateReturned();

            //_configurationInterface = new ConfigurationInterface(databaseBusiness);
            _configurationInterface = new ConfigurationInterface();

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

            if (_moralisBalanceApplication is null)
                return;

            if (_tokenDtoOrigin.Adress is null)
                return;

            retorno = (PriceOfTokenDto)(await _moralisBalanceApplication.GetTokenPrice(_tokenDtoOrigin)).Object;

            //await _moralisBalanceApplication.GetWalletBalanceDefault(_walletDtoOrigin);
            //await _moralisBalanceApplication.GetWalletBalance(_walletDtoOrigin);
            //await _moralisBalanceApplication.GetTransactionDetails("0x34a234638b0cbf184b6985cf0db2ac3a5b6522b6c9636a746a651c727fb219ab");

            valorToken.Text = retorno.UsdPrice.ToString();
        }

        private async void btnBalance_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            if (_moralisBalanceApplication is null)
                return;

            await _moralisBalanceApplication.GetWalletBalanceOfToken(_walletDtoOrigin, _tokenDtoOrigin); //TODO deu exception aqi quando clicava em balance e token price para token fora da carteira

            balance.Text = _tokenDtoOrigin.Name + " : " + _tokenDtoOrigin.Balance;
        }

        private async void btnSwapTokens_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            await _moralisBalanceApplication?.SwapTokensAsync(_walletDtoOrigin, _tokenDtoOrigin, _tokenDtoDestination);

            ReturnedExtension.InsertLogMessage(_returned, "Form - Fim");
        }

        private async void btnTransferirParaDestino_Click(object sender, EventArgs e)
        {
            consoleMessage.Clear();
            FillObjectsFromForm();

            ReturnedExtension.InsertLogMessage(_returned, "Form - Inicio");

            await _moralisBalanceApplication?.SendToWalletAsync(_walletDtoOrigin, _walletDtoDestination, _tokenDtoOrigin);

            ReturnedExtension.InsertLogMessage(_returned, "Form - Fim");
        }

        private void configurationDefaultMenuItem_Click(object sender, EventArgs e)
        {
            _configurationInterface.ShowDialog();
        }
    }
}