using Microsoft.AspNetCore.Mvc;
using Tourest.Models.HomePage;
using Tourest.Helper;
using Tourest.BL.AdminPage;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class HomepageController : Controller
    {
       ClsImg oClsImg = new ClsImg();
       HomePageImages oHomePageImages = new HomePageImages();
       ClsHomePageImages oClsHomePageImages = new ClsHomePageImages();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SaveImage(IFormFile MainImage, IFormFile SecondImage1, IFormFile SecondImage2)
        {
            string dirname = @"wwwRoot/Uploads/HomePage/HeaderImages";
            string Error;
            // Validation for image type don't forget
            if (MainImage == null || SecondImage1 == null || SecondImage2 == null)
            {
                Error = "Please Enter All Images";
                return View("Index", Error);
            }
            oHomePageImages.MainImage = await oClsImg.UploadedFile(MainImage, dirname);
            oHomePageImages.SubImage1 = await oClsImg.UploadedFile(SecondImage1, dirname);
            oHomePageImages.SubImage2 = await oClsImg.UploadedFile(SecondImage2, dirname);
            bool isAdded = oClsHomePageImages.Add(oHomePageImages);
            if (isAdded)
            {
                TempData["status"] = "success";
                TempData["message"] = "Add new Home Page Images";
            }
            else
            {
                TempData["status"] = "field";
                TempData["message"] = "Error The Images Not Added";
            }
            return RedirectToAction(controllerName: "Home" ,actionName:"Index");

        }
    }
}
