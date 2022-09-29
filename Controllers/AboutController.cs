using Microsoft.AspNetCore.Mvc;
using System.Data;
using Tourest.BL.HomePage;

namespace Tourest.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
            oClsAbout = new ClsAbout();
        }
        private readonly ClsAbout oClsAbout;
        public IActionResult Index()
        {
            return View(oClsAbout.GetAll());
        }
    }
}
