using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenQubit.DigitalLib.TestClient.Web.Controllers
{
    public class SystemPathsController : Controller
    {
        // GET: SystemPaths
        public ActionResult Index()
        {
            return View();
        }

        // GET: SystemPaths/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SystemPaths/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemPaths/Create
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

        // GET: SystemPaths/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SystemPaths/Edit/5
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

        // GET: SystemPaths/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SystemPaths/Delete/5
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
