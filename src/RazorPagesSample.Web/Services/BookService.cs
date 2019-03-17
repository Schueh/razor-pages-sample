using System;
using System.Collections.Generic;
using System.Linq;
using RazorPagesSample.Web.Data;
using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;

        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
            _bookContext.Database.EnsureCreated();
        }

        public Book GetBook(int id)
        {
            return _bookContext.Books.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookContext.Books;
        }

        public IEnumerable<Book> GetRecentBooks()
        {
            return _bookContext.Books.OrderByDescending(x => x.ReleaseDate);
        }

        public void UpdateBook(Book book)
        {
            _bookContext.Update(book);
            _bookContext.SaveChanges();
        }
    }
}