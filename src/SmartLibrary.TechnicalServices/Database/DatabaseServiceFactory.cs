using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SmartLibrary.TechnicalServices.Database
{
    public static class DatabaseServiceFactory
    {
        public static IDatabaseServices<T> Create<T>(
            IServiceCollection services,
            string engine, 
            string connectionString
        ) 
            where T : DbContext
        {
            return engine switch
            {
                "SQLServer" => new SQLServerService<T>(services, connectionString),
                "MySQL" => new MySQLService<T>(services, connectionString),
                _ => throw new Exception("DB Driver Not Found!"),
            };
        }
    }
}
