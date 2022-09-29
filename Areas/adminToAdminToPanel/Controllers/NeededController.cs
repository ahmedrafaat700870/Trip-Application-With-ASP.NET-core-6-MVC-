using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class NeededController : Controller
    {
        public NeededController()
        {
            oClsNeeded = new ClsNeeded();
        }
        private readonly ClsNeeded oClsNeeded;
        public IActionResult List(int id)
        {
            if (id == 0)
                id = Convert.ToInt32(TempData["id"]);
            ViewBag.OptoinId = id;
            return View(oClsNeeded.GetAll(id));
        }
        public IActionResult Add(string NeededName, int OptionId)
        {
            TempData["id"] = OptionId;
            oClsNeeded.Add(NeededName, OptionId);
            return RedirectToAction(actionName: "List");
        }
        public IActionResult Delete(int id , int OptionId)
        {
            TempData["id"] = OptionId;
            oClsNeeded.Delete(id);
            return RedirectToAction(actionName: "List");
        }
    }
}
