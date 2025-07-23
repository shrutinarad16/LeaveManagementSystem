using System.Web.Mvc;
using LeaveApp.Models;
using System.Linq;
using System.Net.Mail;
using System.Data.Entity;

namespace LeaveApp.Controllers
{
    public class LeaveController : Controller
    {
        [Authorize]
        public ActionResult Apply() => View();

        [HttpPost]
        public ActionResult Apply(LeaveApplication leave)
        {
            using (var db = new ApplicationDbContext())
            {
                leave.Username = Session["Username"].ToString();
                leave.Status = "Draft";
                db.LeaveApplications.Add(leave);
                db.SaveChanges();

                SendEmail("manager@company.com", "New Leave Application", "A new leave application is pending.");
                return RedirectToAction("MyApplications");
            }
        }

        public ActionResult MyApplications()
        {
            string username = Session["Username"].ToString();
            using (var db = new ApplicationDbContext())
            {
                var list = db.LeaveApplications.Where(x => x.Username == username).ToList();
                return View(list);
            }
        }

        [HttpGet]
        public ActionResult Approve()
        {
            string role = Session["Role"].ToString();
            using (var db = new ApplicationDbContext())
            {
                var applications = db.LeaveApplications
                    .Where(l => (role == "Manager" && l.Status == "Draft") ||
                                (role == "HR" && l.Status == "Manager"))
                    .ToList();
                return View(applications);
            }
        }

        [HttpPost]
        public ActionResult Approve(int id, string decision)
        {
            using (var db = new ApplicationDbContext())
            {
                var app = db.LeaveApplications.Find(id);
                if (decision == "Approve")
                {
                    app.Status = Session["Role"].ToString() == "Manager" ? "Manager" : "HR Finalized";
                }
                else
                {
                    app.Status = "Rejected";
                }
                db.SaveChanges();
            }
            return RedirectToAction("Approve");
        }

        private void SendEmail(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage("admin@leave.com", to, subject, body);
            SmtpClient client = new SmtpClient("smtp.yourserver.com");
            client.Send(mail);
        }
    }
}
