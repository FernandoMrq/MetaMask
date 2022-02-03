using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Applications;
using MRQ.CryptoBot.Business;
using MRQ.CryptoBot.Domains.Adapter.Data;
using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domains.Adapter.Token;
using MRQ.CryptoBot.Domains.Application;
using MRQ.CryptoBot.Domains.Business;
using MRQ.CryptoBot.Domains.Entities;
using MRQ.CryptoBot.Domains.Entities.Configurations;
using MRQ.CryptoBot.Domains.Entities.Moralis;
using MRQ.CryptoBot.Integration.Moralis;
using MRQ.CryptoBot.Integration.Nethereum;
using MRQ.CryptoBot.Repository.Service;

namespace MRQ.CryptoBot.Client.Configurations
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceApplication, TokenPriceApplication>();
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceBusiness, TokenPriceBusiness>();
            services.AddTransient<IWalletBalanceBusiness, WalletBalanceBusiness>();
            services.AddTransient<IOperationBusiness, OperationBusiness>();
            return services;
        }

        public static IServiceCollection AddAdapter(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceAdapter, MoralisTokenPriceAdapter>();
            services.AddTransient<IBlockChainOperationAdapter, PancakeSwapAdapter>();
            services.AddTransient<ISQLiteEntityAdapter<Balance>, EntityService<Balance>>();
            services.AddTransient<ISQLiteEntityAdapter<NativePrice>, EntityService<NativePrice>>();
            services.AddTransient<ISQLiteEntityAdapter<Wallet>, EntityService<Wallet>>();
            services.AddTransient<ISQLiteEntityAdapter<Token>, EntityService<Token>>();
            services.AddTransient<ISQLiteEntityAdapter<Configuration>, EntityService<Configuration>>();
            services.AddTransient<ISQLiteEntityAdapter<RoutersForSwap>, EntityService<RoutersForSwap>>();
            services.AddTransient<ISQLiteEntityAdapter<Router>, EntityService<Router>>();
            services.AddTransient<ISQLiteEntityAdapter<ApiKey>, EntityService<ApiKey>>();

            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

    }
}
