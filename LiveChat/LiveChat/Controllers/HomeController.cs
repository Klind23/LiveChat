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
                return RedirectToAction("Index", "Home");
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
                var userDetails = context.Perdorues.Where(x => x.username == perdorues.username && x.password == perdorues.password).FirstOrDefault();

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
                    Session["UserID"] = userDetails.userId.ToString();
                    Session["Username"] = userDetails.username.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterModel register)
        {
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
