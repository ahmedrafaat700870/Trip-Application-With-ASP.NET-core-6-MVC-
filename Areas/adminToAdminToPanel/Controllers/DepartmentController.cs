using Microsoft.AspNetCore.Mvc;
using Tourest.BL;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class DepartmentController : Controller
    {
        public DepartmentController()
        {
            oClsDepartment = new ClsDepartment();
        }
        public readonly ClsDepartment oClsDepartment;
        public IActionResult List()
        {
            return View(oClsDepartment.GetAllDepartments());
        }
        public IActionResult Add()
        {
            return View(new DepartmentToursModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(DepartmentToursModel Department)
        {
            if (!ModelState.IsValid)
                return View("Add", Department);
            if (Department.DepartmentTourId > 0)
            {
                // Update  Row in Database
                bool isUpdated = oClsDepartment.Update(Department);
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
                bool isAdded = oClsDepartment.Add(Department);
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
            return View("Add", oClsDepartment.GetOne(id));
        }
        public IActionResult Delete(int id)
        {
            bool isDeleted = oClsDepartment.Delete(id);
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
