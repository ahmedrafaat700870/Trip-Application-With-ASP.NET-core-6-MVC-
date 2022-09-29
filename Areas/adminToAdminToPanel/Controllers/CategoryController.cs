using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class CategoryController : Controller
    {
        public CategoryController()
        {
            oClsCategory = new ClsCategory();
        }
        public readonly ClsCategory oClsCategory;
        public IActionResult List()
        {
            return View(oClsCategory.GetAllCategory());
        }
        public IActionResult Add()
        {
            return View(new CategoryModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CategoryModel Department)
        {
            if (!ModelState.IsValid)
                return View("Add", Department);
            if (Department.CategoryId > 0)
            {
                // Update  Row in Database
                bool isUpdated = oClsCategory.Update(Department);
                if (isUpdated)
                {
                    TempData["status"] = "success";
                    TempData["message"] = "Update Successfully";
                }
                else
                {
                    TempData["status"] = "field";
                    TempData["message"] = "Error In Update";
                }
            }
            else
            {
                // Add new Row in Database
                bool isAdded = oClsCategory.Add(Department);
                if (isAdded)
                {
                    TempData["status"] = "success";
                    TempData["message"] = "Add New Department Successfully";
                }
                else
                {
                    TempData["status"] = "field";
                    TempData["message"] = "Error In Add Department";
                }
            }
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
        public IActionResult Update(int id)
        {
            return View("Add", oClsCategory.GetOne(id));
        }
        public IActionResult Delete(int id)
        {
            bool isDeleted = oClsCategory.Delete(id);
            if (isDeleted)
            {
                TempData["status"] = "success";
                TempData["message"] = "Delete Department Successfully";
            }
            else
            {
                TempData["status"] = "field";
                TempData["message"] = "Error In Delete Department";
            }
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
    }
}
