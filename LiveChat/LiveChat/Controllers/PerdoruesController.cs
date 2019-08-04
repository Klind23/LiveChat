using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveChat.Controllers
{
    public class PerdoruesController : Controller
    {
        // GET: Perdorues
        public ActionResult Index()
        {
            return View();
        }

        // GET: Perdorues/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perdorues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perdorues/Create
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

        // GET: Perdorues/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Perdorues/Edit/5
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

        // GET: Perdorues/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perdorues/Delete/5
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
