using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SmartLibrary.TechnicalServices.Database
{
    class MySQLService<T> : BaseDatabaseService<T> where T : DbContext
    {
        public MySQLService(IServiceCollection services, string connectionString) 
            : base(services, connectionString)
        {

        }

        public override void Configure()
        {
            base.AppServices.AddDbContextPool<T>(options =>
            {
                options.UseMySql(base.ConnectionString);
            });
        }
    }
}
