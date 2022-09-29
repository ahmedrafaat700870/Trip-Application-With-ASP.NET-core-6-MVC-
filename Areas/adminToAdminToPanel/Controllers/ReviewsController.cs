using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class ReviewsController : Controller
    {
        public ReviewsController()
        {
            oClsReviesBage = new ClsReviesBage();
        }
        private readonly ClsReviesBage oClsReviesBage;
        public IActionResult List()
        {
            return View(oClsReviesBage.GetAll());
        }
        public IActionResult Delete(int id)
        {
            oClsReviesBage.Delete(id);
            return RedirectToAction("List");
        }
    }
}
