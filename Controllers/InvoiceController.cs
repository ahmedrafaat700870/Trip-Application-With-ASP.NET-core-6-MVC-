using Microsoft.AspNetCore.Mvc;

namespace Tourest.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
