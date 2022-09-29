using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class IncludedController : Controller
    {
        public IncludedController ()
        {
            oClsIncluded = new ClsIncluded();
        }
        private readonly ClsIncluded oClsIncluded;
        public IActionResult List(int id)
        {
            if (id == 0)
                id = Convert.ToInt32(TempData["id"]);
            ViewBag.OptoinId = id;
            return View(oClsIncluded.GetAll(id));
        }
        public IActionResult Add(string IncludedName, int OptionId , bool isIncluded)
        {
            TempData["id"] = OptionId;
            oClsIncluded.Add(IncludedName, OptionId , isIncluded);
            return RedirectToAction(actionName: "List");
        }
        public IActionResult Delete(int id , int OptionId)
        {
            TempData["id"] = OptionId;
            oClsIncluded.Delete(id);
            return RedirectToAction(actionName: "List");
        }
    }
}
