using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SmartLibrary.TechnicalServices.Database
{
    public abstract class BaseDatabaseService<T> : IDatabaseServices<T> where T : DbContext
    {
        protected IServiceCollection AppServices { get; private set; }
        protected string ConnectionString { get; private set; }
        public BaseDatabaseService(IServiceCollection services, string connectionString)
        {
            this.AppServices = services;
            this.ConnectionString = connectionString;
        }
        public abstract void Configure();
    }
}
