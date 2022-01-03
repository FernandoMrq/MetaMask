using MetaMask.Repository.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MRQ.CryptoBot.Client.Configurations
{
    public static class ConfigureDatabase
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext, SQLiteContext>(options =>
                options.UseSqlite(configuration.GetConnectionString(""))
            );

            return services;
        }
    }
}
