using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class RWController : Controller
    {
        // GET: RW
        public ActionResult Index()
        {
            return View();
        }

        // GET: RW/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RW/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RW/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RW/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RW/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RW/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RW/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}