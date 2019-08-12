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
        public ActionResult Authorize(PerdoruesModel perdorues)
        {
            using (var context = new LivechatContext())
            {
                var userDetails = context.Perdorues.Where(x => x.Username == x.Username && x.Password == x.Password)
                                                   .FirstOrDefault();
                if (userDetails == null)
                {
                    perdorues.LoginErrorMessage = "Wrong password or username.";
                    return View("Index", perdorues);
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