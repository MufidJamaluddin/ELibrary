using SmartLibrary.Web.Models.Entity;
using SmartLibrary.WebAPI.Models.Schema;
using System.Collections.Generic;
using System.Linq;

namespace SmartLibrary.Web.Models.Repository
{
    public class BookRepository : BaseRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public List<Book> GetBooks()
        {
            return this.DbContext.Books.Where(x => x.Title != null).ToList();
        }

        public Book GetBookById(int id)
        {
            return this.DbContext.Books.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
