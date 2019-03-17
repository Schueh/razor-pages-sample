using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesSample.Web.Models;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web.Pages
{
    public class BooksModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly ILogger _logger;

        public IEnumerable<Book> Books { get; set; }

        public BooksModel(IBookService bookService, ILogger<BooksModel> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                Books = _bookService.GetBooks();
                throw new ApplicationException("Sample exception.");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error on getting books.", ex);
            }
        }

        public IActionResult OnPostDelete(int id)
        {
            var book = _bookService.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }

            _bookService.DeleteBook(book);
            return RedirectToPage("Books");
        }
    }
}