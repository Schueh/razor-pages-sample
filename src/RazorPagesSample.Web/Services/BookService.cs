using System.Collections.Generic;
using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public class BookService : IBookService
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "Lord of the Rings" },
                new Book { Title = "Harry Potter" },
                new Book { Title = "Get Programming with F#" },
                new Book { Title = "Clean Code" },
                new Book { Title = "Are your Lights on?" },
                new Book { Title = "The Only Story" }
            };
        }
    }
}