using LiveChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class LoginController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Authorize(UserModel user)
        {
            using (var context = new LivechatContext())
            {
                var userDetails = context.Perdorues.Where(x => x.Username == user.Username && x.Password == user.Password)
                                                   .FirstOrDefault();
                if (userDetails == null)
                {
                    user.LoginErrorMessage = "Wrong password or username.";
                    return View("Index", user);
                }
                else
                {
                    Session["UserID"] = userDetails.UserId;
                    return RedirectToAction("Index", "Chat");
                }
            }
        }        
    }
}