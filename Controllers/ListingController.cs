using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TradeMeSample.Models;

namespace TradeMeSample.Controllers
{
    public class ListingController : Controller
    {
        private static readonly ListingViewModel[] Listings =
        {
            new ListingViewModel {id = 1, name = "My Ferrari", StartDate = DateTime.Now, Featured = false, Price = 50000 },
            new ListingViewModel {id = 2, name = "My House", StartDate = DateTime.Now, Featured = true, Price = 500000 }
        };


        // GET: Listing
        public ActionResult Index()
        {
            return View(Listings);
        }

        // GET: Listing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Listing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Listing/Create
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

        // GET: Listing/Edit/5
        public ActionResult Edit(int id)
        {
            var modelToEdit = Listings.Single(model => model.id == id);
            return View(modelToEdit);
        }

        // POST: Listing/Edit/5
        [HttpPost]
        public ActionResult Edit(LoginViewModel model)
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

        // GET: Listing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Listing/Delete/5
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
