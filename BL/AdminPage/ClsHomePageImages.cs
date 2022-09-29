using Tourest.Models;
using Tourest.Models.HomePage;
namespace Tourest.BL.AdminPage
{
    public class ClsHomePageImages
    {
        public ClsHomePageImages()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public bool Add(HomePageImages imgs)
        {
            try
            {
                Context.TbHomePageImages.Add(imgs);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<HomePageImages> GetAllImages()
        {
            try
            {
                var Images = Context.TbHomePageImages.ToList();
                return Images;
            }
            catch
            {
                return new List<HomePageImages>();
            }
        }
    }
}
