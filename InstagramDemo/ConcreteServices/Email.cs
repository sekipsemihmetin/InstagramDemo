using InstagramDemo.AbstractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.ConcreteServices
{
    public class Email : IEmailService
    {
        private readonly string _fromEmail;
        private readonly string _password;

        public Email(string fromEmail,string password)
        {
            _fromEmail = fromEmail;
            _password = password;
        }
        public void SendEmail(string email, string subject, string bady)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.Credentials = new NetworkCredential(_fromEmail, _password);
                client.EnableSsl = true;

                var mailMessage = new MailMessage()
                {
                    From = new MailAddress(_fromEmail),
                    Subject = subject,
                    Body = bady,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email);
                client.Send(mailMessage);
            } 
        }
    }
}
