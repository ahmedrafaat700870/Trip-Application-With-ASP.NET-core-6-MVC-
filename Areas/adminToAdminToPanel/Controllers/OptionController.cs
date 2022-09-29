using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.Helper;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class OptionController : Controller
    {
        public OptionController()
        {
            oClsOptionH = new ClsOptionH();
            oClsOption = new ClsOption();
        }
        private readonly ClsOptionH oClsOptionH;
        private readonly ClsOption oClsOption;
        public IActionResult List(int id)
        {
            if(id == 0)
            {
                id = Convert.ToInt32(TempData["id"]);
            }
            ViewBag.id = id;
            return View(oClsOption.GetAll(id));
        }

        public IActionResult Add(int id, int OptionId)
        {
            ToursOptionModel oToursOptionModel = new ToursOptionModel();
            ViewBag.id = id;
            if (OptionId == 0)
            {
                // add new Option
                oToursOptionModel.TourId = id;
                return View(oToursOptionModel);
            }
            else
            {
                // update Option
                oToursOptionModel = oClsOption.GetById(OptionId);
                return View(oToursOptionModel);
            }
        }
        public IActionResult Delete(int id, int TourId)
        {
            bool isDeleted = oClsOption.Delete(id);
            if (isDeleted)
            {
                TempData["status"] = "success";
                TempData["message"] = "Delete  option Successfully";
                TempData["id"] = TourId;
            }
            else
            {
                TempData["status"] = "field";
                TempData["message"] = "Error in deleting option";
                TempData["id"] = TourId;
            }
            return RedirectToAction(controllerName: "Option", actionName: "List");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ToursOptionModel oTourOptionModel, int rating, bool membershipRadios)
        {
            if (!ModelState.IsValid)
                return View("Add", oTourOptionModel);
            if (oTourOptionModel.TourOptionId == 0)
            {
                // add new option
                bool isAdded = oClsOption.Add(oTourOptionModel, rating, membershipRadios);
                if (isAdded)
                    if (isAdded)
                    {
                        TempData["status"] = "success";
                        TempData["message"] = "Add new option Successfully";
                        TempData["id"] = oTourOptionModel.TourId;
                    }
                    else
                    {
                        TempData["status"] = "field";
                        TempData["message"] = "Error in adding option";
                        TempData["id"] = oTourOptionModel.TourId;
                    }
            }
            else
            {
                // update option
                bool isUpdated = oClsOption.Update(oClsOptionH.GetTour(oTourOptionModel, rating, membershipRadios));

                if (isUpdated)
                {
                    TempData["status"] = "success";
                    TempData["message"] = "Update option Successfully";
                    TempData["id"] = oTourOptionModel.TourId;
                }
                else
                {
                    TempData["status"] = "field";
                    TempData["message"] = "Error in updating option";
                    TempData["id"] = oTourOptionModel.TourId;
                }
            }
            return RedirectToAction(controllerName: "Option", actionName: "List");
        }
    }
}
