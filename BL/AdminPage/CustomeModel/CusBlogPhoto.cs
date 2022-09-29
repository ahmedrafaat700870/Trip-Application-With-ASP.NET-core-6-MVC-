using Tourest.Models.Blogs;

namespace Tourest.BL.AdminPage.CustomeModel
{
    public class CusBlogPhoto
    {
        public CusBlogPhoto()
        {
            PhotosDescriptions = new List<BlogPhotoModel>();
            TbPhotosDesription = new BlogPhotoModel();
        }
        public List<BlogPhotoModel> PhotosDescriptions { get; set; }
        public BlogPhotoModel TbPhotosDesription { get; set; }
    }
}
