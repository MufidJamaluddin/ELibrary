using Microsoft.EntityFrameworkCore;

namespace SmartLibrary.TechnicalServices.Database
{
    public interface IDatabaseServices<T> where T : DbContext
    {
        void Configure();
    }
}
