using Microsoft.AspNetCore.Mvc;

namespace Tourest.Areas.adminToAdminToPanel.Controllers
{
    [Area("adminToAdminToPanel")]
    public class TextEditorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
