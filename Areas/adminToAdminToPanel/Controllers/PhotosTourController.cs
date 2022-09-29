using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using Tourest.BL.AdminPage;
using Tourest.BL.CustomeModel;
using Tourest.Helper;
using Tourest.Models.CustomsTables;
using Tourest.Models.TourTabels;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class PhotosTourController : Controller
    {
        public PhotosTourController()
        {
            oClsPhotoTour = new ClsPhotoTour();
            oClsImg = new ClsImg();

        }
        private readonly ClsPhotoTour oClsPhotoTour;
        private readonly ClsImg oClsImg;
        private readonly string DirName = @"wwwRoot//Uploads//Tours";
        public IActionResult List(int id)
        {
            if (id == 0 && TempData["TourId"] != null)
                id = Convert.ToInt32(TempData["TourId"]);
            if (TempData.ContainsKey("error"))
                ViewBag.Error = TempData["Error"];
            CusPhotosTour oCusPhotosTour = new CusPhotosTour()
            {
                TbPhoto = new PhotoModel
                {
                    TourId = id,
                },
                TbPhotos = oClsPhotoTour.GetAll(id)
            };
            return View(oCusPhotosTour);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveNewImage(int TourId, IFormFile Photo)
        {
            PhotoModel oPhotoModel = new PhotoModel();
            TempData["TourId"] = TourId;
            if (Photo == null)
            {
                TempData["error"] = "Please Choose Photo";
                return RedirectToAction(actionName: "List", TourId);
            }
            oPhotoModel.PhotoSrc =  await oClsImg.UploadedFile(Photo, DirName);
            oPhotoModel.TourId = TourId;
            oClsPhotoTour.SavePhoto(oPhotoModel);
            return RedirectToAction(actionName: "List");
        
        }
        public async Task< IActionResult> Delete(string id , string tourid )
        {
            bool isDeleted = await oClsPhotoTour.RemovePhoto(Convert.ToInt32(id), DirName);
            TempData["TourId"] = tourid;
            return RedirectToAction(actionName: "List");
        }
    }
}
