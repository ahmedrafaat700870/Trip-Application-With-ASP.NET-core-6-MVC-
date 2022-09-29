using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tourest.BL.AdminPage;
using Tourest.Migrations;
using Tourest.Models.CustomsTables;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class SectionNamesController : Controller
    {
        public SectionNamesController()
        {
            oClsNamesSections = new ClsNamesSections();
        }
        private readonly ClsNamesSections oClsNamesSections;

        public IActionResult Index()
        {
            return View(oClsNamesSections.Get());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(SectionNamesModel oSectionNamesModel)
        {
            ModelState.Remove<SectionNamesModel>(x => x.id);
            if (!ModelState.IsValid)
                return View("Index" ,oSectionNamesModel);
            oClsNamesSections.UpdateOrEdit(oSectionNamesModel);
            TempData["status"] = "success";
            TempData["message"] = "Add Names Successfully";
            return RedirectToAction(actionName: "", controllerName:"Home") ;
        }
    }
}
