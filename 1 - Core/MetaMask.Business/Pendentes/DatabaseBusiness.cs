using MRQ.CryptoBot.Domains.Adapter.Data;
using MRQ.CryptoBot.Domains.Business;
using MRQ.CryptoBot.Domains.Entities.Configurations;

namespace MRQ.CryptoBot.Business.Pendentes
{
    public class DatabaseBusiness : IDatabaseBusiness
    {
        private readonly IConfigurationAdapter _configurationAdapter;

        public DatabaseBusiness(IConfigurationAdapter configurationAdapter)
        {
            _configurationAdapter = configurationAdapter;
        }

        public async Task<IEnumerable<Configuration>> GetAll()
        {
            return await _configurationAdapter.GetAll();
        }

        public async Task<bool> Insert(Configuration config)
        {
            return await _configurationAdapter.Insert(config);
        }
    }
}
