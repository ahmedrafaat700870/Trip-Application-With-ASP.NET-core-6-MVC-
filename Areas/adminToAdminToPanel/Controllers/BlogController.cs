using Microsoft.AspNetCore.Mvc;

using Tourest.BL.AdminPage;
using Tourest.BL.AdminPage.CustomeModel;
using Tourest.Helper;
using Tourest.Models.Blogs;

namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class BlogController : Controller
    {
        public BlogController()
        {
            oClsBlog = new ClsBlog();
            Img = new ClsImg();
        }
        private readonly ClsBlog oClsBlog;
        private readonly ClsImg Img;
        private readonly string DirName = @"wwwRoot//Uploads//Blog";
        public IActionResult List()
        {
            return View(oClsBlog.GetAll());
        }
        public IActionResult Add(int id)
        {
            BlogModel oBlogModel = new BlogModel();
            if (id != 0)
                oBlogModel = oClsBlog.GetById(id);
            return View(oBlogModel);
        }
        public IActionResult Delete(int id)
        {
            oClsBlog.Delete(id);
            return RedirectToAction(actionName: "List");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Save(BlogModel oBlogModel)
        {
            if (!ModelState.IsValid)
                return View("Add", oBlogModel);
            if (oBlogModel.BlogId == 0)
            {
                // Add new blog
                oClsBlog.Add(oBlogModel);
            }
            else
            {
                // update blog
                oClsBlog.Update(oBlogModel);
            }
            return RedirectToAction(actionName: "List");
        }
        public IActionResult DesciptionAndPhotosList(int id)
        {
            if (id == 0)
                id = Convert.ToInt32(TempData["BlogId"]);
            ViewBag.id = id;
            CusBlogPhoto cusBlogPhoto = new CusBlogPhoto
            {
                PhotosDescriptions = oClsBlog.GetAllBlogDescriptionsPhotos(id)
            }; 
            return View(cusBlogPhoto);
        }
        public async Task<IActionResult> SavePhotoAndDesription(int BlogId, CusBlogPhoto oCusBlogPhoto ,IFormFile Photo)
        {
            oCusBlogPhoto.TbPhotosDesription.BlogPhotoSrc = await Img.UploadedFile(Photo, DirName);
            oClsBlog.AddPhotoDescription(oCusBlogPhoto.TbPhotosDesription, BlogId);
            TempData["BlogId"] = BlogId;
            return RedirectToAction(actionName: "DesciptionAndPhotosList");
        }
        public async Task<IActionResult> DeletePhotoDescription (int id ,int BlogId)
        {
            BlogPhotoModel oBlogPhoto = oClsBlog.GetByIdPhotoDescription(id);
            await Img.DeleteFile(DirName, oBlogPhoto.BlogPhotoSrc);
            oClsBlog.DeletePhotoDescription(oBlogPhoto);
            TempData["BlogId"] = BlogId;
            return RedirectToAction(actionName: "DesciptionAndPhotosList");
        }
    }
}
