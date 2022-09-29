using Tourest.BL.AdminPage;
using Tourest.Models.Blogs;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.HomePage.CustomesModels
{
    public class CusBlog
    {
        public CusBlog()
        {
            TbBlog = new BlogModel();
       /*     TbReviews = new List<ReviewsModel>();*/
            AddReviw = new ReviewsModel();
        }
        public BlogModel TbBlog { get; set; }
  /*      public List<ReviewsModel> TbReviews { get; set; }*/
        public ReviewsModel AddReviw { get; set; }

    }
}
