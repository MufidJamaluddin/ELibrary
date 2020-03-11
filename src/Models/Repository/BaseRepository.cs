using SmartLibrary.WebAPI.Models.Schema;

namespace SmartLibrary.Web.Models.Repository
{
    public class BaseRepository
    {
        protected AppDbContext DbContext { get; }
        public BaseRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
    }
}
