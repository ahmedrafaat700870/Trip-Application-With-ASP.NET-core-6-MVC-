using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.BL.HomePage;
using Tourest.BL.HomePage.CustomesModels;

namespace Tourest.Controllers
{
    public class ShopController : Controller
    {
        public ShopController()
        {
            oClsStore = new ClsStore();
            oClsCategory = new ClsCategory();
            oClsLocation = new ClsLocation();
        }
        private readonly ClsStore oClsStore;
        private readonly ClsCategory oClsCategory;
        private readonly ClsLocation oClsLocation;
        public IActionResult List(int cateforyId, int LocationId, int MaxPrice, int MinPrice, string TourName)
        {
            ViewBag.Location = oClsLocation.GetAllLocation();

            ViewBag.Category = oClsCategory.GetAllCategory();
            CusStore oCusStore = new CusStore
            {
                RightTours = oClsStore.GetRigthTours(),
                SeachTours = oClsStore.SrechTours(cateforyId, LocationId)
            };
            return View(oCusStore);
        }
        public IActionResult Sort(int LocationId, int CategoryId)
        {
            ViewBag.Location = oClsLocation.GetAllLocation();

            ViewBag.Category = oClsCategory.GetAllCategory();
            CusStore oCusStore = new CusStore
            {
                RightTours = oClsStore.GetRigthTours(),
                SeachTours = oClsStore.SearchById(CategoryId, LocationId)
            };
            return View("List" , oCusStore);
        }
        [HttpPost]
        public IActionResult Search (string? Search)
        {
            ViewBag.Location = oClsLocation.GetAllLocation();
            ViewBag.Category = oClsCategory.GetAllCategory();
            CusStore oCusStore = new CusStore
            {
                RightTours = oClsStore.GetRigthTours(),
                SeachTours = oClsStore.Search(Search)
            };

            return View("List" , oCusStore);
        }
    }
}
