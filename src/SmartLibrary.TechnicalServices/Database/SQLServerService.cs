using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SmartLibrary.TechnicalServices.Database
{
    class SQLServerService<T> : BaseDatabaseService<T> where T : DbContext
    {
        public SQLServerService(IServiceCollection services, string connectionString) 
            : base(services, connectionString)
        {

        }

        public override void Configure()
        {
            base.AppServices.AddDbContextPool<T>((options) =>
            {
                options.UseSqlServer(base.ConnectionString);

                options.UseInternalServiceProvider(
                    new ServiceCollection()
                        .AddEntityFrameworkSqlServer()
                        .BuildServiceProvider()
                );
            });
        }

    }
}
