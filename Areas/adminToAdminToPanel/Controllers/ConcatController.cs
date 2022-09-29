using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class ConcatController : Controller
    {
        public ConcatController()
        {
            oClsConcat = new ClsConcat();
        }
        private readonly ClsConcat oClsConcat;
        public IActionResult List()
        {
            return View(oClsConcat.GetAll());
        }
        public IActionResult Show(int id)
        {
            return View(oClsConcat.Get(id));
        }
    }
}
