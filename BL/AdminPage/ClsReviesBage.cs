using Tourest.Models.CustomsTables;
using Tourest.Models;

namespace Tourest.BL.AdminPage
{
    public class ClsReviesBage
    {
        public ClsReviesBage()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<ReviewsBageModel> GetAll ()
        {
            try
            {
                return Context.TbReviewBage.ToList();
            }
            catch
            {
                return new List<ReviewsBageModel>();
            }
        }
        public bool Delete(int id)
        {
            try
            {
                Context.TbReviewBage.Remove(Context.TbReviewBage.Find(id));
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
