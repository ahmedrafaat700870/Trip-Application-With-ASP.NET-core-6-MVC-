using Microsoft.AspNetCore.Mvc;
using Tourest.BL;
using Tourest.Helper;
using Tourest.Models.CustomsTables;
namespace Tourest.Areas.Admin.Controllers
{
        [Area("adminToAdminToPanel")]
    public class InsetegramController : Controller
    {
        public InsetegramController()
        {
            oClsInstegram = new ClsInstegram();
            oClsImg = new ClsImg();
        }
        private readonly string dirName = @"wwwRoot//Uploads//Insetegram";
        private readonly ClsImg oClsImg;
        private readonly ClsInstegram oClsInstegram;
        public IActionResult List()
        {
            return View(oClsInstegram.GetAll());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(IFormFile Photo, string src)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(actionName: "List");
            InestegramModel oInestegramModel = new InestegramModel
            {
                InstagramSrc = src,
                PhotoSrc = await oClsImg.UploadedFile(Photo, dirName)
            };
            oClsInstegram.Add(oInestegramModel);
            return RedirectToAction(actionName: "List");
        }
        public async Task<IActionResult> Delete(int id)
        {
            InestegramModel oInestegramModel = oClsInstegram.Get(id);
            oClsInstegram.Delete(oInestegramModel , dirName);
            return RedirectToAction(actionName: "List");
        }
    }
}
