using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PageHits.Controllers
{
    public class JSONController : Controller
    {
        // GET: JSON
        public ActionResult Index()
        {
            return View();
        }

        // GET: JSON/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JSON/Create
        public JsonResult SendJsonDate()
        {
            var result = new
            {
                comment = "Some string",
                attachments = new string[] { "/folder/file-1.jpg", "/folder/file-2.jpg" }
            };

            return this.Json(result);
        }

        // POST: JSON/Create
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

        // GET: JSON/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JSON/Edit/5
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

        // GET: JSON/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JSON/Delete/5
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
