//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using MRQ.CryptoBot.Repository;

//namespace MRQ.CryptoBot.Client.Configurations
//{
//    public static class ConfigureDatabase
//    {
//        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
//        {
//            services.AddDbContext<DbContext, SQLiteContext>(option => option.UseSqlite("Data Source=context.db"));
//            services.AddDbContext<SQLiteContext>(option => option.UseSqlite("Data Source=context.db"));

//            return services;
//        }

//        //public static IApplicationBuilder DatabaseMigrate(this IApplicationBuilder app)
//        //{
//        //    //using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
//        //    //{
//        //    //    using (var context = serviceScope.ServiceProvider.GetService<MrqEntityContext>())
//        //    //    {
//        //    //        context.Database.Migrate();
//        //    //    }
//        //    //}

//        //    return app;
//        //}
//    }
//}
