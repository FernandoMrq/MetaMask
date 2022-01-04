using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Domain.Adapter.Data;
using MRQ.CryptoBot.Integration.Moralis;

namespace MRQ.CryptoBot.Infra
{
    public static class ExternalServiceExtension
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection services) 
        {
            //TODO trazer IConfiguration
            services.AddHttpClient<IMoralisBalanceAdapter, MoralisBalanceAdapter>(); //TODO colocar baseadress aqui 

            return services;
        }
    }
}
