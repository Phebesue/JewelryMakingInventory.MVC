using JewelryMaking.Models;
using JewelryMaking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewelryMakingInventory.Web.MVC.Controllers
{
    public class FindingController : Controller
    {
        // GET: Finding/Index
        public ActionResult Index()
        {
            var findingService = new FindingService();
            var model = findingService.GetFindings();

            return View(model);
        }

        //GET: Finding/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Finding/Create
        [HttpPost]
        public ActionResult Create(FindingCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            var service = new FindingService();

            if (service.CreateFinding(model))
            {
                TempData["SaveResult"] = "Your finding was added.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Finding could not be added.");
            return View(model);
        }
        //GET: Finding/Details/{id}
        public ActionResult Details(int id)
        {
            var service = new FindingService();
            var model = service.GetFindingById(id);

            return View(model);
        }
        //GET:Finding/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = new FindingService();
            var detail = service.GetFindingById(id);
            var model = new FindingEdit
            {
                FindingId = detail.FindingId,
                Category = detail.Category,
                SubType = detail.SubType,
                Size = detail.Size,
                Color = detail.Color,
                Association = detail.Association,
                Quantity = detail.Quantity,
                Cost = detail.Cost,
                Description = detail.Description,
                //Location = detail.Location,
                //Source = detail.Source,
                //FindingImage = detail.FindingImage
            };
            return View(model);
        }
        //POST: Finding/Edit/{id}
        [HttpPost]
        public ActionResult Edit(int id, FindingEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.FindingId != id)
            {
                ModelState.AddModelError("", "ID# Mismatch");
                return View(model);
            }
            var service = new FindingService();
            if (service.UpdateFinding(model))
            {
                TempData["SaveResult"] = "Your finding was updated.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Your finding could not be updated.");
            return View(model);
        }
        //GET Finding/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = new FindingService();
            var model = service.GetFindingById(id);

            return View(model);
        }
        //POST: Finding/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            var service = new FindingService();
            service.DeleteFinding(id);
            TempData["SaveResult"] = "Your finding was deleted.";
            return RedirectToAction("Index");
        }
    }
}