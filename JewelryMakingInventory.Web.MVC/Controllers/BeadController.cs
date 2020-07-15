using JewelryMaking.Models;
using JewelryMaking.Services;
using System.Web;
using System.Web.Mvc;

namespace JewelryMakingInventory.Web.MVC.Controllers
{
    public class BeadController : Controller
    { // GET: Bead/Index
        public ActionResult Index()
        {
            var beadService = new BeadService();
            var model = beadService.GetBeads();
            return View(model);
        }
        // GET: Bead/Index/Subtotal
        [Route("Bead/Index/Subtotal")]

        public ActionResult IndexTotal()
        {
            var beadService = new BeadService();
            var model = beadService.GetBeadSubTotal();
            return View(model);
        }
        //GET: Bead/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: Bead/Create
        [HttpPost]
        public ActionResult Create(BeadCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            HttpPostedFileBase file = Request.Files["ImageData"];
            var service = new BeadService();

            if (service.CreateBead(model))
            {
                TempData["SaveResult"] = "Your bead was added.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Bead could not be added.");

            return View(model);
        }
        //GET: Bead/Details/{id}
        public ActionResult Details(int id)
        {
            var svc = new BeadService();
            var model = svc.GetBeadById(id);

            return View(model);
        }
        //GET:Bead/Edit/{id}
        public ActionResult Edit(int id)
        {
            var service = new BeadService();
            var detail = service.GetBeadById(id);
            var model = new BeadEdit
            {
                BeadId = detail.BeadId,
                Brand = detail.Brand,
                Type = detail.Type,
                SubType = detail.SubType,
                Shape = detail.Shape,
                Size = detail.Size,
                Color = detail.Color,
                Quantity = detail.Quantity,
                Cost = detail.Cost,
                Description = detail.Description,
                LocationId = detail.LocationId,
                SourceId = detail.SourceId,
                FileAsBytes = detail.FileAsBytes,
            };
            return View(model);
        }
        //POST: Bead/Edit/{id}
        [HttpPost]
        public ActionResult Edit(int id, BeadEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.BeadId != id)
            {
                ModelState.AddModelError("", "ID# Mismatch");
                return View(model);
            }
            var service = new BeadService();
            if (service.UpdateBead(model))
            {
                TempData["SaveResult"] = "Your bead was updated.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Your bead could not be updated.");
            return View(model);
        }
        //GET Bead/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new BeadService();
            var model = svc.GetBeadById(id);

            return View(model);
        }
        //POST: Bead/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            var service = new BeadService();
            service.DeleteBead(id);
            TempData["SaveResult"] = "Your bead was deleted.";
            return RedirectToAction("Index");
        }
    }
}