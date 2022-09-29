using Tourest.Models;
using Tourest.Models.HomePage;
namespace Tourest.BL
{
    public class ClsHomePageImages
    {
        public ClsHomePageImages() { }
        TouristContext db = new TouristContext();
        public bool Add(HomePageImages imgs)
        {
            try
            {
                db.TbHomePageImages.Add(imgs);
                db.SaveChanges();
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
                var Images = db.TbHomePageImages.ToList();
                return Images;
            }
            catch
            {
                return new List<HomePageImages>();
            }
        }
    }
}
