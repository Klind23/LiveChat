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
        public ActionResult Register(PerdoruesModel perdorues)
        {
            if (ModelState.IsValid)
                using (var context = new LivechatContext())
                {
                    context.Perdorues.Add(perdorues);
                    context.SaveChanges();
                }

            else perdorues.LoginErrorMessage = "Passwords do not match !";
            return View("Index", perdorues);
        }
    }
}