using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenQubit.DigitalLib.TestClient.Web.Controllers
{
    public class ResourcePathController : Controller
    {
        // GET: ResourcePath
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResourcePath/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResourcePath/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResourcePath/Create
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

        // GET: ResourcePath/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResourcePath/Edit/5
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

        // GET: ResourcePath/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResourcePath/Delete/5
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
