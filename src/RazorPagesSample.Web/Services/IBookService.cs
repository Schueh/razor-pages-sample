using System.Collections.Generic;
using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetRecentBooks();
        Book GetBook(int id);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}