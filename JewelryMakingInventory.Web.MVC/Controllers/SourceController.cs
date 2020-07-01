using JewelryMaking.Models;
using JewelryMaking.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace JewelryMakingInventory.Web.MVC.Controllers
{
    public class SourceController : Controller
    {
        // GET: Source/Index
        public ActionResult Index()
        {
            var sourceService = new SourceService();
            var model = sourceService.GetSources();
            return View(model);
        }
        //GET: Source/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Source/Create
        [HttpPost]
        public ActionResult Create(SourceCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            var service = new SourceService();

            if (service.CreateSource(model))
            {
                TempData["SaveResult"] = "Your source was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Source could not be created.");

            return View(model);
        }
        //GET: Source/Details
        public ActionResult Details(int id)
        {
            var svc = new SourceService();
            var model = svc.GetSourceById(id);

            return View(model);
        }
        //GET: Source/Edit
        public ActionResult Edit(int id)
        {
            var service = new SourceService();
            var detail = service.GetSourceById(id);
            var model = new SourceEdit
            {
                SourceId = detail.SourceId,
                Name = detail.Name,
                WebSite = detail.WebSite,
                ShowOrLocation = detail.ShowOrLocation,
                Address = detail.Address,
                City = detail.City,
                State = detail.State,
                ZipCode = detail.ZipCode,
                Note = detail.Note
            };
            return View(model);
        }
        //POST: Source/Edit
        [HttpPost]
        public ActionResult Edit(int id, SourceEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.SourceId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = new SourceService();
            if (service.UpdateSource(model))
            {
                TempData["SaveResult"] = "Your source was updated.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Your source could not be updated.");
            return View(model);
        }
        // GET: Source/Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new SourceService();
            var model = svc.GetSourceById(id);

            return View(model);
        }
        // POST: Source/Delete
        [HttpPost]
        [ActionName("Delete")]
            public ActionResult DeletePost (int id)
        {
            var service = new SourceService();
            service.DeleteSource(id);
            TempData["SaveResult"] = "Your source was deleted";
            return RedirectToAction("Index");
        }

        //private SourceService CreateSourceService()
        //{
        //    var sourceService = new SourceService();
        //    return sourceService;
        //}
    }
}