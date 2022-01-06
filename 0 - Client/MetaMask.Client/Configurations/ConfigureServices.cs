using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Business;
using MRQ.CryptoBot.Domain.Adapter.Data;
using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domain.Business;
using MRQ.CryptoBot.Domain.Entities.Moralis;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.CryptoBot.Integration.Moralis;
using MRQ.CryptoBot.Integration.Nethereum;
using MRQ.CryptoBot.Orchestrator;
using MRQ.CryptoBot.Repository.Service;

namespace MRQ.CryptoBot.Client.Configurations
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddOrchestrator(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceOrchestrator, TokenPriceOrchestrator>();
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceBusiness, TokenPriceBusiness>();
            return services;
        }

        public static IServiceCollection AddAdapter(this IServiceCollection services)
        {
            services.AddTransient<ISQLiteEntityAdapter<Balance>, EntityService<Balance>>();
            services.AddTransient<ISQLiteEntityAdapter<NativePrice>, EntityService<NativePrice>>();
            services.AddTransient<ITokenPriceAdapter, MoralisTokenPriceAdapter>();
            services.AddTransient<IBlockChainOperationAdapter, PancakeSwapAdapter>();

            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

    }
}
