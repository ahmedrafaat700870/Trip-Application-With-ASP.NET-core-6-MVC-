using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tourest.BL.AdminPage;
using Tourest.BL.CustomeModel;
using Tourest.Helper;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{


    [Area("adminToAdminToPanel")]
    public class TourController : Controller
    {
        public TourController()
        {
            oClsTour = new ClsTourAdmin();
            oClsCategory = new ClsCategory();
            oClsLocation = new ClsLocation();
            oClsImg = new ClsImg();
            oClsPhoto = new ClsPhoto();
            oClsLoactionHomePage = new ClsLocationHomePage();
        }
        public readonly ClsTourAdmin oClsTour;
        public readonly ClsCategory oClsCategory;
        public readonly ClsLocation oClsLocation;
        public readonly ClsImg oClsImg;
        public readonly ClsPhoto oClsPhoto;
        private readonly ClsLocationHomePage oClsLoactionHomePage;

        public readonly string dirname = @"wwwRoot//Uploads//Tours";
        public IActionResult List()
        {
            ViewBag.Location = oClsLocation.GetAllLocation();
            ViewBag.Category = oClsCategory.GetAllCategory();
            return View(oClsTour.GetAllToursLocatoinCategory());
        }
        public IActionResult Add(int id)
        {
            ViewBag.Location = oClsLocation.GetAllLocation();
            ViewBag.Category = oClsCategory.GetAllCategory();
            ViewBag.LocationHomePage = oClsLoactionHomePage.GetAll();
            return View(oClsTour.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ToursModel oTourModel, bool optionsRadios)
        {
            oTourModel.isNew = optionsRadios;
            ModelState.Remove<ToursModel>(x => x.LocationHomePageId);
            if (!ModelState.IsValid)
            {
                ViewBag.Location = oClsLocation.GetAllLocation();
                ViewBag.Category = oClsCategory.GetAllCategory();
                ViewBag.LocationHomePage = oClsLoactionHomePage.GetAll();
                return View("Add" , oTourModel);
            }
            oTourModel.CreatedDate = DateTime.Now;
            if (oTourModel.TourId == 0)
            {
                // Add new Tour
                oClsTour.Add(oTourModel);
                TempData["status"] = "success";
                TempData["message"] = "Add New Tour Successfully";
            }
            else
            {
                oClsTour.Update(oTourModel);
                TempData["status"] = "success";
                TempData["message"] = "Update Tour Successfully";
                // Update Tour
            }
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
        public IActionResult Sort(int? CategoryId ,int? LocationId)
        {
            ViewBag.Location = oClsLocation.GetAllLocation();
            ViewBag.Category = oClsCategory.GetAllCategory();
            return View("List", oClsTour.Search(CategoryId, LocationId)); 
        }
        public async Task< IActionResult> Delete (int id)
        {
            await oClsTour.Delete(id, dirname);
            return View("List");
        }
    }
}
