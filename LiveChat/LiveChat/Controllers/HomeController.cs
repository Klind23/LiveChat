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
            return View();
        }

        public ActionResult Register()
        {
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
        public ActionResult Register(PerdoruesModel perdorues)
        {
            if (perdorues.Password == perdorues.confirmPassword)
                if (ModelState.IsValid)
                    using (var context = new LiveChatContext())
                    {
                        context.Perdorues.Add(perdorues);
                        context.SaveChanges();
                    }
            return View("Login");
        }
    }
}
