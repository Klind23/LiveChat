using LiveChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (user.Password == user.ConfirmPassword)
                using (var context = new LivechatContext())
                {
                    context.Perdorues.Add(user);
                    context.SaveChanges();
                }

            else user.LoginErrorMessage = "Passwords do not match !";
            return View();
        }
    }
}