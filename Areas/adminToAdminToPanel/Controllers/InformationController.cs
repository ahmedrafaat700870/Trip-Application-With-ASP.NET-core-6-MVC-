using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.Helper;
using Tourest.Models.CustomsTables;
namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class InformationController : Controller
    {
        public InformationController()
        {
            oClsInformation = new ClsInformation();
            oClsImg = new ClsImg();
        }
        private readonly string SrcFileImage = @"wwwRoot/Uploads/HomePage/";
        private readonly ClsInformation oClsInformation;
        private readonly ClsImg oClsImg;
        public IActionResult List()
        {
            return View(oClsInformation.GetInformation());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult >Save(InformationModel Info , IFormFile LogoImage, IFormFile FooterImage)
        {
            if (!ModelState.IsValid)
                return View("List", Info);
            Info.LogoImage = await oClsImg.UploadedFile(LogoImage , SrcFileImage+ "Logo");
            /*Info.FooterImage = await oClsImg.UploadedFile(FooterImage, SrcFileImage + "Footer");*/
            bool isAdded = oClsInformation.UpdateInformation(Info);
            if (isAdded)
            {
                TempData["status"] = "success";
                TempData["message"] = "Update Successfully";
            }
            else
            {
                TempData["status"] = "field";
                TempData["message"] = "Error In Update";
            }
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
    }
}
