namespace SmartLibrary.Infrastructure.Data.Repository
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
