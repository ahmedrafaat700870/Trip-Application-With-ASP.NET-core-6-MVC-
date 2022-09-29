using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class LocationController : Controller
    {
        public LocationController ()
        {
            oClsLocation = new ClsLocation();
        }
        public readonly ClsLocation oClsLocation;
        public IActionResult List()
        {
            return View(oClsLocation.GetAllLocation());
        }
        public IActionResult Add()
        {
            return View(new LocationModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(LocationModel location)
        {
            if (!ModelState.IsValid)
                return View("Add" , location);
            if(location.LocationId>0)
            {
                // Update  Row in Database
                bool isUpdated = oClsLocation.UpdaeLocation(location);
                if(isUpdated)
                {
                    TempData["status"] = "success";
                    TempData["message"] = "Update Successfully";
                } else
                {
                    TempData["status"] = "field";
                    TempData["message"] = "Error In Update";
                }
            }
            else
            {
                // Add new Row in Database
                bool isAdded = oClsLocation.AddLocation(location);
                if(isAdded)
                {
                    TempData["status"] = "success";
                    TempData["message"] = "Add New Location Successfully";
                } else
                {
                    TempData["status"] = "field";
                    TempData["message"] = "Error In Add Location";
                }
            }
            return RedirectToAction(controllerName: "Home" , actionName: "Index");
        }
        public IActionResult Update(int id)
        {
            return View("Add" , oClsLocation.GetLocationById(id));
        }
        public IActionResult Delete (int id)
        {
            bool isDeleted = oClsLocation.Delete(id);
            if (isDeleted)
            {
                TempData["status"] = "success";
                TempData["message"] = "Delete Location Successfully";
            }
            else
            {
                TempData["status"] = "field";
                TempData["message"] = "Error In Delete Location";
            }
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
    }
}
