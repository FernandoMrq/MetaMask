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
            services.AddHttpClient<ITokenPriceAdapter, MoralisTokenPriceAdapter>()
                .ConfigureHttpClient(req => req.BaseAddress = new Uri(InfraResource.MoralisBaseUrl));

            return services;
        }
    }
}
