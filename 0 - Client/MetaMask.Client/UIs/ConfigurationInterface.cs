using MRQ.CryptoBot.Domains.Business;
using MRQ.CryptoBot.Domains.Entities.Configurations;

namespace MRQ.CryptoBot.Client.Interfaces
{
    public partial class ConfigurationInterface : Form
    {
        private readonly IDatabaseBusiness _databaseBusiness;

        public ConfigurationInterface()
        {
            _databaseBusiness = Program.ServiceProvider?.GetService(typeof(IDatabaseBusiness)) as IDatabaseBusiness;

            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Configuration con = new Configuration
            {
                DefaultGas = txtDefaultGas.Text,
                DefaultGasPrice = txtDefaultGasPrice.Text
            };

            _databaseBusiness.Insert(con);

            var retorno = _databaseBusiness.GetAll();
        }
    }
}
