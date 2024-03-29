using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Client.Configurations;
using MRQ.CryptoBot.Infra;

namespace MRQ.CryptoBot.Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureServices();
            Application.Run(new Form1());
        }

        public static IServiceProvider? ServiceProvider
        { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddInfra();
            services.AddAdapter();
            services.AddBusiness();
            services.AddApplication();
            services.AddExternalServices();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}