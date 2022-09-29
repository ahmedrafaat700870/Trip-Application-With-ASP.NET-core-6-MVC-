using Tourest.Models.TourTabels;

namespace Tourest.BL.HomePage.CustomesModels
{
    public class CusStore
    {
        public CusStore()
        {
            RightTours = new List<ToursModel>();
        }
        public List<ToursModel> RightTours { get; set; }
        public List<ToursModel> SeachTours { get; set; }
    }
}
