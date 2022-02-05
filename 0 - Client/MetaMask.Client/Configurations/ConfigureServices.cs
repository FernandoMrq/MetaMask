using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Applications;
using MRQ.CryptoBot.Business;
using MRQ.CryptoBot.Business.Pendentes;
using MRQ.CryptoBot.Domains.Adapter.Data;
using MRQ.CryptoBot.Domains.Adapter.PancakeSwap;
using MRQ.CryptoBot.Domains.Adapter.Token;
using MRQ.CryptoBot.Domains.Application;
using MRQ.CryptoBot.Domains.Business;
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
            services.AddTransient<IDatabaseBusiness, DatabaseBusiness>();
            return services;
        }

        public static IServiceCollection AddAdapter(this IServiceCollection services)
        {
            services.AddTransient<ITokenPriceAdapter, MoralisTokenPriceAdapter>();
            services.AddTransient<IBlockChainOperationAdapter, PancakeSwapAdapter>();
            //services.AddTransient<DbContext, SQLiteContext>();
            //services.AddTransient<ISQLiteEntityAdapter<Balance>, EntityDatabaseService<Balance>>();
            //services.AddTransient<ISQLiteEntityAdapter<NativePrice>, EntityDatabaseService<NativePrice>>();
            //services.AddTransient<ISQLiteEntityAdapter<Wallet>, EntityDatabaseService<Wallet>>();
            //services.AddTransient<ISQLiteEntityAdapter<Token>, EntityDatabaseService<Token>>();
            //services.AddTransient<ISQLiteEntityAdapter<Configuration>, EntityDatabaseService<Configuration>>();
            //services.AddTransient<ISQLiteEntityAdapter<RoutersForSwap>, EntityDatabaseService<RoutersForSwap>>();
            //services.AddTransient<ISQLiteEntityAdapter<Router>, EntityDatabaseService<Router>>();
            //services.AddTransient<ISQLiteEntityAdapter<ApiKey>, EntityDatabaseService<ApiKey>>();
            services.AddTransient<IConfigurationAdapter, ConfigurationDatabaseService>();

            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

    }
}
