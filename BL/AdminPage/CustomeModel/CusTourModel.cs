using Tourest.Models.TourTabels;
namespace Tourest.BL.CustomeModel
{
    public class CusTourModel
    {
        public CusTourModel()
        {
            TbCateogry = new List<CategoryModel>();
            TbTours = new ToursModel();
            TbLocatoin = new List<LocationModel>();
        }
        public List<CategoryModel> TbCateogry { get; set; }
        public List<LocationModel> TbLocatoin { get; set; }
        public ToursModel TbTours { get; set; }
    }
}
