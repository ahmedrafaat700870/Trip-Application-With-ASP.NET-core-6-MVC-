using Microsoft.AspNetCore.Mvc;
using Tourest.BL.AdminPage;
using Tourest.BL.HomePage;
using Tourest.Models.CustomsTables;

namespace Tourest.Controllers
{
    public class ReviewsController : Controller
    {
        public ReviewsController()
        {
            oClsAdmin = new ClsReviesBage();
            oClsReiwesBage = new ClsReiwesBage();
        }
        private readonly ClsReiwesBage oClsReiwesBage;
        private readonly ClsReviesBage oClsAdmin;
        public IActionResult List()
        {
            return View(oClsAdmin.GetAll());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(string name , string email , string comment )
        {
            if (!ModelState.IsValid)
                return RedirectToAction(actionName:"List");
            ReviewsBageModel oReviewsBageModel = new ReviewsBageModel
            {
                name = name,
                description = comment,
                CretaedDate = DateTime.Now
            };
            oClsReiwesBage.Add(oReviewsBageModel);
            return RedirectToAction(actionName: "List");
        }
    }
}
