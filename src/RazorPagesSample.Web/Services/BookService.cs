using System;
using System.Collections.Generic;
using System.Linq;
using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public class BookService : IBookService
    {
        private readonly IList<Book> _books;

        public BookService()
        {
            _books = new List<Book>
            {
                new Book { Id = 1, Title = "Lord of the Rings", Description = "Lorem ipsum", Author = "J.R.R. Tolkien", ReleaseDate = new DateTime(1950, 2, 4), Image = "book_1.png" },
                new Book { Id = 2, Title = "Harry Potter", Description = "Lorem ipsum", Author = "J.K. Rowling", ReleaseDate = new DateTime(2001, 10, 15), Image = "book_2.png" },
                new Book { Id = 3, Title = "Get Programming with F#", Description = "Lorem ipsum", Author = "Isaac Abraham", ReleaseDate = new DateTime(2016, 8, 23), Image = "book_1.png" },
                new Book { Id = 4, Title = "Clean Code", Description = "Lorem ipsum", Author = "Robert C. Martin", ReleaseDate = new DateTime(2006, 6, 3), Image = "book_2.png" },
                new Book { Id = 5, Title = "Are your Lights on?", Description = "Lorem ipsum", Author = "Gerald M. Weinberg", ReleaseDate = new DateTime(1995, 3, 30), Image = "book_1.png" },
                new Book { Id = 6, Title = "The Only Story", Description = "Lorem ipsum", Author = "Julian Barnes", ReleaseDate = new DateTime(2019, 2, 1), Image = "book_2.png" }
            };
        }

        public Book GetBook(int id)
        {
            return _books.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
    }
}