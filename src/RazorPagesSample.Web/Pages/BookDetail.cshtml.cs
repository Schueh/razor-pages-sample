using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Web.Models;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web.Pages
{
    public class BookDetailModel : PageModel
    {
        public Book Book { get; private set; }

        public void OnGet(string slug)
        {
            var bookService = new BookService();
            Book = bookService.GetBooks().SingleOrDefault(x => x.Slug == slug);
        }
    }
}