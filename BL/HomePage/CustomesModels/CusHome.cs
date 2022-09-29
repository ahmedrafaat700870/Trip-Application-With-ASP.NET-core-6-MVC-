using Tourest.BL.CustomeModel;
using Tourest.Models.Blogs;
using Tourest.Models.CustomsTables;
using Tourest.Models.HomePage;
using Tourest.Models.TourTabels;

namespace Tourest.BL.HomePage.CustomesModels
{
    public class CusHome
    {
        public CusHome()
        {
            Images = new List<HomePageImages>();
            TbBlogs = new List<BlogModel>();
        }
        public List<HomePageImages> Images { get; set; }
        public List<ToursModel> SectionOneTours { get; set; }
        public List<ToursModel> SectionTowTours { get; set; }
        public List<ToursModel> SectionThreeTours{ get; set; }
        public List<ToursModel> SectionFourTours{ get; set; }
        public List<ToursModel> Top100 { get; set; }
        public List<BlogModel> TbBlogs { get; set; }
        public Dictionary<string , List<ToursModel>> SortedToursByCategory { get; set; }
        public List<ToursModel> MaxPrice { get; set; }
        public List<ToursModel> MinPrice { get; set; }
        public List<InestegramModel> Instegram { get; set; }

    }
}
