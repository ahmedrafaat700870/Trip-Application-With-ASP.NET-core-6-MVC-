using Microsoft.AspNetCore.Mvc;

namespace Tourest.Controllers
{
    public class RegesterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
