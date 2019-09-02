using LiveChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(PerdoruesModel perdorues)
        {
            using (var context = new LiveChatContext())
            {
                var userDetails = context.Perdorues.Where(x => x.Username == perdorues.Username && x.Password == perdorues.Password).First();
                if (userDetails == null)
                {
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