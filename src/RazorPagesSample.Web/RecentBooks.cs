using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web
{
    public class RecentBooks : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var bookService = new BookService();
            return View(bookService.GetRecentBooks().Take(count));
        }
    }
}