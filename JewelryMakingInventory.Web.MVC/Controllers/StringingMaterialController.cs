﻿using JewelryMaking.Models;
using JewelryMaking.Services;
using System.Web;
using System.Web.Mvc;

namespace JewelryMakingInventory.Web.MVC.Controllers
{
    public class StringingMaterialController : Controller
    {
        // GET: StringingMaterial/Index
        public ActionResult Index()
        {
            var locationService = new StringingMaterialService();
            var model = locationService.GetStringingMaterials();

            return View(model);
        }
        // GET: StringingMaterial/Index/SubTotal
        [Route("StringingMaterial/Index/Subtotal")]
        public ActionResult IndexTotal()
        {
            var locationService = new StringingMaterialService();
            var model = locationService.GetStringingMaterialSubTotal();

            return View(model);
        }
        //GET: StringingMaterial/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: StringingMaterial/Create
        [HttpPost]
        public ActionResult Create(StringingMaterialCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            HttpPostedFileBase file = Request.Files["ImageData"];
            var service = new StringingMaterialService();

            if (service.CreateStringingMaterial(model))
            {
                TempData["SaveResult"] = "Your stringing material was added.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Stringing material could not be added.");

            return View(model);
        }
        //GET: StringingMaterial/Details/{id}
        public ActionResult Details(int id)
        {
            var svc = new StringingMaterialService();
            var model = svc.GetStringingMaterialById(id);

            return View(model);
        }
        //GET:StringingMaterial/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = new StringingMaterialService();
            var detail = service.GetStringingMaterialById(id);
            var model = new StringingMaterialEdit
            {
                StringingMaterialId = detail.StringingMaterialId,
                Type = detail.Type,
                Material = detail.Material,
                Size = detail.Size,
                Color = detail.Color,
                Length = detail.Length,
                Cost = detail.Cost,
                Description = detail.Description,
                LocationId = detail.LocationId,
                SourceId = detail.SourceId,
                FileAsBytes = detail.FileAsBytes,
                ImageFile = detail.ImageFile
            };
            return View(model);
        }
        //POST: StringingMaterial/Edit/{id}
        [HttpPost]
        public ActionResult Edit(int id, StringingMaterialEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            HttpPostedFileBase file = Request.Files["ImageData"];

            if (model.StringingMaterialId != id)
            {
                ModelState.AddModelError("", "ID# Mismatch");
                return View(model);
            }
            var service = new StringingMaterialService();
            if (service.UpdateStringingMaterial(model))
            {
                TempData["SaveResult"] = "Your stringing material was updated.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Your stringing material could not be updated.");
            return View(model);
        }
        //GET StringingMaterial/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new StringingMaterialService();
            var model = svc.GetStringingMaterialById(id);

            return View(model);
        }
        //POST: StringingMaterial/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            var service = new StringingMaterialService();
            service.DeleteStringingMaterial(id);
            TempData["SaveResult"] = "Your stringing material was deleted.";
            return RedirectToAction("Index");
        }
    }
}