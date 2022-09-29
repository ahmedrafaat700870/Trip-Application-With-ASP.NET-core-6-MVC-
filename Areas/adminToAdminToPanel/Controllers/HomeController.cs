using Microsoft.AspNetCore.Mvc;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (TempData.ContainsKey("status") && TempData.ContainsKey("message"))
            {
                ViewBag.status = TempData["status"];
                ViewBag.message = TempData["message"];
            }
            return View();
        }
    }
}
