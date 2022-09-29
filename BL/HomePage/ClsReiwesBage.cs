using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.HomePage
{
    public class ClsReiwesBage
    {
        public ClsReiwesBage()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public bool Add (ReviewsBageModel oReviewBageModel)
        {
            try
            {
                Context.TbReviewBage.Add(oReviewBageModel);
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
