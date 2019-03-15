using RazorPagesSample.Web.Models;

namespace RazorPagesSample.Web.Services
{
    public interface IEmailService
    {
        void SendMail(Contact contact);
    }
}