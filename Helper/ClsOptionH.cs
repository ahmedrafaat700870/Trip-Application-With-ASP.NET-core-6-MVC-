using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.Helper
{
    public class ClsOptionH
    {
        public ClsOptionH()
        {

        }

        public ToursOptionModel GetTour (ToursOptionModel oTourOptionModel, int rating, bool membershipRadios)
        {
            oTourOptionModel.Rate = rating;
            oTourOptionModel.isSelected = membershipRadios;
            return oTourOptionModel;
        }

    }
}
