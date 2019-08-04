using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class AsistentController : Controller
    {
        // GET: Asistent
        public ActionResult Index()
        {
            return View();
        }

        // GET: Asistent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asistent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asistent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Asistent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asistent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Asistent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asistent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
