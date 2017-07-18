using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenQubit.DigitalLib.TestClient.Web.Controllers
{
    public class MultimediaTypeController : Controller
    {
        // GET: MultimediaType
        public ActionResult Index()
        {
            return View();
        }

        // GET: MultimediaType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MultimediaType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultimediaType/Create
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

        // GET: MultimediaType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MultimediaType/Edit/5
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

        // GET: MultimediaType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MultimediaType/Delete/5
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
