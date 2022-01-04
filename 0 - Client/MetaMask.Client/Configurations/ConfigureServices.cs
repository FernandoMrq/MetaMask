using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Business;
using MRQ.CryptoBot.Domain.Adapter.Data;
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
            services.AddTransient<IMoralisBalanceOrchestrator, MoralisBalanceOrchestrator>();
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<IMoralisBalanceBusiness, MoralisBalanceBusiness>();
            return services;
        }

        public static IServiceCollection AddAdapter(this IServiceCollection services)
        {
            services.AddTransient<ISQLiteEntityAdapter<Balance>, EntityService<Balance>>();
            services.AddTransient<ISQLiteEntityAdapter<NativePrice>, EntityService<NativePrice>>();
            services.AddTransient<IMoralisBalanceAdapter, MoralisBalanceAdapter>();
            services.AddTransient<IPancakeSwapAdapter, PancakeSwapAdapter>();

            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

    }
}
