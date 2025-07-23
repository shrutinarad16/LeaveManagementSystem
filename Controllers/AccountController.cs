using System.Web.Mvc;
using LeaveApp.Models;
using System.Web.Security;

namespace LeaveApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public ActionResult Login() => View();

        [HttpPost]
        public ActionResult Login(User user)
        {
            using (var db = new ApplicationDbContext())
            {
                var loggedUser = db.Users
                    .FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

                if (loggedUser != null)
                {
                    Session["Username"] = loggedUser.Username;
                    Session["Role"] = loggedUser.Role;
                    return RedirectToAction("Apply", "Leave");
                }
                ModelState.AddModelError("", "Invalid credentials.");
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
