using SmartLibrary.Domain.BorrowBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibrary.Domain.BorrowBook.Repository
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        Book GetBookById(int id);
        List<Book> SearchBook(Book book);
    }
}
