using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.BL.HomePage;
using Tourest.BL.HomePage.CustomesModels;
using Tourest.Models.Blogs;
using Tourest.Models.CustomsTables;

namespace Tourest.Controllers
{
    public class BlogController : Controller
    {

        public BlogController()
        {
            oClsBlog = new ClsBlog();
            oClsReivew = new ClsReivew();
        }
        private readonly ClsBlog oClsBlog;
        private readonly ClsReivew oClsReivew;
        public IActionResult Index(int id)
        {
            if (id == 0)
                id = Convert.ToInt32(TempData["BlogId"]);
            return View(oClsBlog.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveComment(string name , int BlogId , string email , string comment )
        {
            if(!ModelState.IsValid)
                return View("Index");
            ReviewsModel oReviewModel = new ReviewsModel
            {
                Name = name,
                BlogId = BlogId,
                Email = email,
                ReviewDescription = comment,
                ReviewDate = DateTime.Now
            }; 
            oClsReivew.Add(oReviewModel);
            TempData["BlogId"] = BlogId;
            return RedirectToAction(actionName: "Index");
        }
    }
}
