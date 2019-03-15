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
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        
        public string Message { get; private set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var emailService = new EmailService();
                emailService.SendMail(Contact);

                Message = "Your email has been sent.";
            }
        }

        public void OnPostSubscribe(string address)
        {
            Message = "Your email address has been added to the subscription list.";
        }
    }
}