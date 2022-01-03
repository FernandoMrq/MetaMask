using MRQ.CryptoBot.Business;
using MRQ.CryptoBot.Domain.Business;
using MRQ.CryptoBot.Domain.Orchestrator;
using MRQ.CryptoBot.Orchestrator;
using Microsoft.Extensions.DependencyInjection;

namespace MRQ.CryptoBot.Client.Configurations
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddOrchestrator(this IServiceCollection services)
        {
            //services.AddScoped<ICryptoOrchestrator, CryptoOrchestrator>();
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            //services.AddTransient<IChromeBusiness, ChromeBusiness>();
            return services;
        }

        public static IServiceCollection AddAdapter(this IServiceCollection services)
        {
            //services.AddTransient<IChromeAdapter, ChromeAdapter>();
            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

    }
}
