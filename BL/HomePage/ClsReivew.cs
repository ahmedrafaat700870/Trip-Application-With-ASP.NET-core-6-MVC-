using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.HomePage
{
    public class ClsReivew
    {
        public ClsReivew()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public bool Add(ReviewsModel oReviewModel)
        {
            try
            {
                Context.Database.ExecuteSqlRaw($"INSERT INTO TbReviews Values ('{oReviewModel.Name}' ,'{oReviewModel.ReviewDescription}' ,GETDATE(), null ,null,{oReviewModel.BlogId} ,'{oReviewModel.Email}');");
                Context.SaveChanges();
                return true ;
            }
            catch
            {
                return false;
            }
        }
    }
}
