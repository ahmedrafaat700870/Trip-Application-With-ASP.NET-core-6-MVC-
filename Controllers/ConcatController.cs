using Microsoft.AspNetCore.Mvc;
using Tourest.BL;
using Tourest.BL.AdminPage;
using Tourest.Models.UsersTabel;
using ClsInformation = Tourest.BL.ClsInformation;

namespace Tourest.Controllers
{
    public class ConcatController : Controller
    {
        public ConcatController()
        {
            oClsInformation = new ClsInformation();
            oClsConcat = new ClsConcat();
        }
        private readonly ClsInformation oClsInformation;
        private readonly ClsConcat oClsConcat;
        public IActionResult Index()
        {
            ViewBag.Information = oClsInformation.GetInformation();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save (ConcatModel oConcatModel)
        {
            if (!ModelState.IsValid)
                return View("Index", oConcatModel);
            oClsConcat.Add(oConcatModel);
            return RedirectToAction(actionName: "Index");
        }
    }
}
