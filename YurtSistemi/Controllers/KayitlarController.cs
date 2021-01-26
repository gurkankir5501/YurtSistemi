using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YurtSistemi.Controllers
{
    public class KayitlarController : Controller
    {
        // GET: Kayitlar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Kayitlar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kayitlar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kayitlar/Create
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

        // GET: Kayitlar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kayitlar/Edit/5
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

        // GET: Kayitlar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kayitlar/Delete/5
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
