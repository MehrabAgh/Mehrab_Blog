using BlogUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BlogUniversity.Controllers
{
    public class ContactMeController : Controller
    {
        public IActionResult Index()
        {
            LayoutData.ChangeDataTitle("", "", "active", "");
            return View("ContactMe");
        }


        public IActionResult SendEmail(string fn , string ln , string em , string mess)
        {
            Email newMail = new()
            {
                From = new MailAddress(em, fn + ln),
                Password = "your outgoing mail password",
                To = new MailAddress("vinodevs.official@gmail.com", "Mehrabaghaee"),
                Subject = "message from user",
                Body = mess,
                Host = "smtp.example.com",
                Port = 123
            };
            if (newMail.send() == 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}
