using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Integration.Moralis;

namespace MRQ.CryptoBot.Infra
{
    public static class ExternalServiceExtension
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection services)
        {
            //TODO trazer IConfiguration.
            //TODO colocar baseadress da URL aqui 
            services.AddHttpClient<ITokenPriceAdapter, MoralisTokenPriceAdapter>();

            return services;
        }
    }
}
