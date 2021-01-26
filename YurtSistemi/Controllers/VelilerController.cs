using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YurtSistemi.Controllers
{
    public class VelilerController : Controller
    {
        // GET: Veliler
        public ActionResult Index()
        {
            return View();
        }

        // GET: Veliler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Veliler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veliler/Create
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

        // GET: Veliler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Veliler/Edit/5
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

        // GET: Veliler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Veliler/Delete/5
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
