using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.Models.CustomsTables;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class FAQController : Controller
    {
        public FAQController()
        {
            oClsFAQ = new ClsFAQ();
        }
        public readonly ClsFAQ oClsFAQ;
        public IActionResult List()
        {
            return View(oClsFAQ.GetAll());
        }
        public IActionResult Add(int id)
        {
            FAQModel oFAQ = new FAQModel();
            if (id != 0)
                oFAQ = oClsFAQ.GetById(id);
            return View(oFAQ);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(FAQModel oFAQ)
        {
            if (!ModelState.IsValid)
                return View("Add" , oFAQ);
            if(oFAQ.id == 0)
            {

                // Add new Row in Database
                oClsFAQ.Add(oFAQ);
           
            }
            else
            {   
                // Update  Row in Database
                oClsFAQ.Update(oFAQ);

            }
            return RedirectToAction(controllerName: "Home" , actionName: "Index");
        }
        public IActionResult Delete (int id)
        {
            oClsFAQ.Delete(oClsFAQ.GetById(id));
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
    }
}
