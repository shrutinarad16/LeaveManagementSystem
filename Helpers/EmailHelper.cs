using System.Net;
using System.Net.Mail;

namespace LeaveApp.Helpers
{
    public class EmailHelper
    {
        public static void SendMail(string toEmail, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(toEmail);
            mail.From = new MailAddress("admin@yourdomain.com");
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.yourserver.com", // e.g., smtp.gmail.com
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("your_email", "your_password"),
                EnableSsl = true
            };
            smtp.Send(mail);
        }
    }
}
