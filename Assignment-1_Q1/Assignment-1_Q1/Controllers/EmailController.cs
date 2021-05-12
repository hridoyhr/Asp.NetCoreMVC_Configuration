using Assignment_1_Q1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Assignment_1_Q1.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmailModel model)
        {
            string to = model.To;
            string subject = model.Subject;
            string body = model.Body;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.From = new MailAddress("mahmudul35-205@diu.edu.bd");
            mailMessage.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gamil.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("mahmudul35-205@diu.edu.bd", "Password");
            smtp.Send(mailMessage);

            ViewBag.message = "The mail has been send to " + mailMessage.To + "Successfuly";

            return View();
        }
    }
}
