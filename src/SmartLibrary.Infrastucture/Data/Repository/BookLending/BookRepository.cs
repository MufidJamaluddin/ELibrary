using SmartLibrary.Domain.BorrowBook.Entity;
using SmartLibrary.Domain.BorrowBook.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SmartLibrary.Infrastructure.Data.Repository
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public Book GetBookById(int id)
        {
            return this.DbContext.Books
                .Where(x => x.Id == id)
                .Select(x => new Book
                {
                    Title = x.Title,
                    Publisher = x.Publisher
                })
                .FirstOrDefault();
        }

        public List<Book> GetBooks()
        {
            return this.DbContext.Books
                .Select(x => new Book
                {
                    Title = x.Title,
                    Publisher = x.Publisher
                })
                .ToList();
        }

        public List<Book> SearchBook(Book book)
        {
            return this.DbContext.Books
                .Where(x =>
                    x.Title == book.Title &&
                    x.Publisher == book.Publisher
                )
                .Select(x => new Book
                {
                    Title = x.Title,
                    Publisher = x.Publisher
                })
                .ToList();
        }
    }
}
