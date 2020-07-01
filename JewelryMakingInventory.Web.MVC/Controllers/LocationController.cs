using JewelryMaking.Models;
using JewelryMaking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewelryMakingInventory.Web.MVC.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location/Index
        public ActionResult Index()
        {
            var locationService = new LocationService();
            var model = locationService.GetLocations();
            return View(model);
        }

        //GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Location/Create
        [HttpPost]
        public ActionResult Create(LocationCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            var service = new LocationService();

            if (service.CreateLocation(model))
            {
                TempData["SaveResult"] = "Your location was added.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Location could not be added.");

            return View(model);
        }
        //GET: Location/Details
        public ActionResult Details(int id)
        {
            var svc = new LocationService();
            var model = svc.GetLocationById(id);

            return View(model);
        }
        //GET:Location/Edit
        public ActionResult Edit(int id)
        {
            var service = new LocationService();
            var detail = service.GetLocationById(id);
            var model = new LocationEdit
            {
                LocationId = detail.LocationId,
                Kind = detail.Kind,
                Size = detail.Size,
                Color = detail.Color,
                Place = detail.Place
            };
            return View(model);
        }
        //POST: Location/Edit
        [HttpPost]
        public ActionResult Edit(int id, LocationEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.LocationId != id)
            {
                ModelState.AddModelError("", "ID# Mismatch");
                return View(model);
            }
            var service = new LocationService();
            if (service.UpdateLocation(model))
            {
                TempData["SaveResult"] = "Your location was updated.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Your location could not be updated.");
            return View(model);
        }
        //GET Location/Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new LocationService();
            var model = svc.GetLocationById(id);

            return View(model);
        }
        //POST: Location/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost (int id)
        {
            var service = new LocationService();
            service.DeleteLocation(id);
            TempData["SaveResult"]= "Your location was deleted.";
            return RedirectToAction("Index");
        }
    }
}