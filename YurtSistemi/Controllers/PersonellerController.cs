using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YurtSistemi.Controllers
{
    public class PersonellerController : Controller
    {
        // GET: Personeller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personeller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personeller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personeller/Create
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

        // GET: Personeller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personeller/Edit/5
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

        // GET: Personeller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personeller/Delete/5
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
