using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartLibrary.TechnicalServices.Database;

namespace SmartLibrary.TechnicalServices
{
    public static class EFDatabaseSetup
    {
        public static void ConfigureEFDatabase<T>(
            IServiceCollection services, 
            string engine, 
            string connectionString
        )
            where T : DbContext
        {
            var databaseServices = DatabaseServiceFactory.Create<T>(services, engine, connectionString);

            databaseServices.Configure();
        }
    }
}
