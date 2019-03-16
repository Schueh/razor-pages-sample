using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web.ViewComponents
{
    public class RecentBooks : ViewComponent
    {
        private readonly IBookService _bookService;

        public RecentBooks(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            return View(_bookService.GetRecentBooks().Take(count));
        }
    }
}