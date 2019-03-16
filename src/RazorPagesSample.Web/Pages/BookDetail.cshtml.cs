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
        private readonly IBookService _bookService;

        public Book Book { get; private set; }

        public BookDetailModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void OnGet(string slug)
        {
            Book = _bookService.GetBooks().SingleOrDefault(x => x.Slug == slug);
        }
    }
}