using System.Diagnostics;
using Tourest.Models.TourTabels;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.BL.HomePage.CustomesModels
{
    public class CusItem
    {
        public CusItem()
        {
            MainTour = new ToursModel();
            TourtOption = new ToursOptionModel();
            ToursRelated = new List<ToursModel>();
        }
        public ToursModel MainTour { get; set; }
        public ToursOptionModel TourtOption { get; set; }
        public List<ToursModel> ToursRelated { get; set; }
    }
}
