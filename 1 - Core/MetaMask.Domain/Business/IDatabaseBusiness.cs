using MRQ.CryptoBot.Domains.Entities.Configurations;

namespace MRQ.CryptoBot.Domains.Business
{
    public interface IDatabaseBusiness
    {
        public Task<IEnumerable<Configuration>> GetAll();
        public Task<bool> Insert(Configuration config);
    }
}
