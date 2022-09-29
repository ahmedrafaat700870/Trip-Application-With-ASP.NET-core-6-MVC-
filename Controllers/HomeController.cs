using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.BL.HomePage.CustomesModels;
using Tourest.BL.HomePage;
using Tourest.Models.TourTabels;
using Tourest.BL;
using ClsHomePageImages = Tourest.BL.AdminPage.ClsHomePageImages;
using ClsLocation = Tourest.BL.AdminPage.ClsLocation;
using Tourest.Models.CustomsTables;
using ClsInformation = Tourest.BL.AdminPage.ClsInformation;

namespace Tourest.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Images = new ClsHomePageImages();
            oClsHome = new ClsHome();
            oClsBlog = new ClsBlog();
            oClsFAQ = new ClsFAQ();
            oClsCategory = new ClsCategory();
            oClsLocation = new ClsLocation();
            oClsInetegram = new ClsInstegram();
            oClsLocationHomePage = new ClsLocationHomePage();
            oClsNamesSections = new ClsNamesSections();
            oClsInformation = new ClsInformation();
        }
        public readonly ClsFAQ oClsFAQ;
        private readonly ClsHomePageImages Images;
        private readonly ClsHome oClsHome;
        private readonly ClsBlog oClsBlog;
        private readonly ClsCategory oClsCategory;
        private readonly ClsLocation oClsLocation;
        private readonly ClsInstegram oClsInetegram;
        private readonly ClsLocationHomePage oClsLocationHomePage;
        private readonly ClsNamesSections oClsNamesSections;
        private readonly ClsInformation oClsInformation;
        public IActionResult Index()
        {
            List<ToursModel> oToursModel = oClsHome.GetAllTours().ToList();
            var Categorys = oClsCategory.GetAllCategory();
            var Locations = oClsLocation.GetAllLocation();
            var LoactionsInHomePage = oClsLocationHomePage.GetAll();
            var SectionNames = oClsNamesSections.Get();
            var Info = oClsInformation.GetInformation();
            ViewBag.NamesSections = SectionNames ?? new SectionNamesModel();
            ViewBag.info = Info ?? new InformationModel();
            ViewBag.Categorys = Categorys;
            ViewBag.Location = Locations;
            CusHome oCusHome = new CusHome
            {
                Images = Images.GetAllImages(),
                SectionOneTours = oToursModel.Where(x => x.LocationHomePageId == LoactionsInHomePage[0].LocationHomePageId).Take(10).ToList(),
                SectionTowTours = oToursModel.Where(x => x.LocationHomePageId == LoactionsInHomePage[1].LocationHomePageId).Take(10).ToList(),
                SectionThreeTours = oToursModel.Where(x => x.LocationHomePageId == LoactionsInHomePage[2].LocationHomePageId).Take(10).ToList(),
                SectionFourTours = oToursModel.Where(x => x.LocationHomePageId == LoactionsInHomePage[3].LocationHomePageId).Take(10).ToList(),
                TbBlogs = oClsBlog.GetAll(),
                Top100 = oToursModel.Take(10).ToList(),
                MaxPrice = oToursModel.OrderBy(x => x.TourPrice).Take(8).ToList(),
                MinPrice = oToursModel.OrderByDescending(x => x.TourPrice).Take(8).ToList(),
                Instegram = oClsInetegram.GetAll()
            };
           
            return View(oCusHome);
        }
        public IActionResult Item()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View(oClsFAQ.GetAll());
        }
    }
}
