using MRQ.CryptoBot.Domains.Adapter.Data;
using MRQ.CryptoBot.Domains.Entities.Configurations;

namespace MRQ.CryptoBot.Repository.Service
{
    public class ConfigurationDatabaseService : EntityDatabaseService<Configuration>, IConfigurationAdapter
    {
        public ConfigurationDatabaseService(SQLiteContext context) : base(context) { }
    }
}
