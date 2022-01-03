using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MRQ.CryptoBot.Repository;

namespace MRQ.CryptoBot.Client.Configurations
{
    public static class ConfigureDatabase
    {
        public static IServiceCollection AddContext(this IServiceCollection services)
        {
            services.AddDbContext<SQLiteContext>(options =>
                options.UseSqlite("configuration.db")
            );

            return services;
        }
    }
}
