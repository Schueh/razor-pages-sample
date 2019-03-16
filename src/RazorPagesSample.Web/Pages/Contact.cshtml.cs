using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Web.Models;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IEmailService _emailService;

        [BindProperty]
        public Contact Contact { get; set; }
        
        public string Message { get; private set; }

        public ContactModel(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _emailService.SendMail(Contact);

                return new RedirectToPageResult("Confirmation", "Contact");
            }

            return Page();
        }

        public IActionResult OnPostSubscribe(string address)
        {
            _emailService.SendMail(address);
            return new RedirectToPageResult("Confirmation", "Subscribe");
        }
    }
}