using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Web.Models;
using RazorPagesSample.Web.Services;

namespace MyApp.Namespace
{
    public class BooksModel : PageModel
    {
        public IEnumerable<Book> Books { get; set; }

        public void OnGet()
        {
            var bookService = new BookService();
            Books = bookService.GetBooks();
        }
    }
}