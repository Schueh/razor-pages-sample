using System.Collections.Generic;
using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
    }
}