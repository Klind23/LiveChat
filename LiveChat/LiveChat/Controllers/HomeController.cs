using LiveChat.Models;
using System.Linq;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Session["UserID"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }

        public ActionResult Register()
        {
            if (Session["UserID"] != null)
            {
                return RedirectToAction("Register", "Home");
            }
            else
                return View();
        }

        [HttpPost]
        public ActionResult Login(PerdoruesModel perdorues)
        {
            using (var context = new LiveChatContext())
            {
                if (!ModelState.IsValid)
                {
                    return View("Login", perdorues);
                }
                //if (perdorues.Username == "klind" && perdorues.Password == "milan4ever")
                //{
                //    return View("Login", perdorues);
                //}
                var userDetails = context.Perdorues.Where(x => x.Username == perdorues.Username && x.Password == perdorues.Password).FirstOrDefault();

                if (userDetails == null)
                {
                    return View("Login", perdorues);
                }
                //if (perdorues.Username != "klind" || perdorues.Password != "milan4ever")
                //{
                //    return View("Login", perdorues);
                //}
                else
                {
                    Session["UserID"] = userDetails.UserId.ToString();
                    Session["Username"] = userDetails.Username.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterModel register)
        {
            if (register.Password == register.confirmPassword)
                if (ModelState.IsValid)
                    using (var context = new LiveChatContext())
                    {
                        context.Register.Add(register);
                        context.SaveChanges();
                    }
            return View("Login");
        }
    }
}
