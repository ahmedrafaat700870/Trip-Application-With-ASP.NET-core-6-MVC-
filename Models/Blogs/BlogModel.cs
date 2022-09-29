using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using Tourest.Models.CustomsTables;
using Tourest.Models.TourTabels;

namespace Tourest.Models.Blogs
{
    public class BlogModel
    {
        public BlogModel()
        {
            TbRiviews = new HashSet<ReviewsModel>();
            TbBlogPhotos = new HashSet<BlogPhotoModel>();
        }
        [Key]
        [ValidateNever]
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Please Enter Blog Titel")]
        public string BlogTitel { get; set; } = String.Empty;
        public DateTime BlogCreatedDate { get; set; }
        [Required(ErrorMessage = "Please Enter Created By")]
        public string BlogCreatedBy { get; set; } = String.Empty;
        [ValidateNever]
        public ICollection<ReviewsModel> TbRiviews { get; set; }
        [ValidateNever]
        public ICollection<BlogPhotoModel> TbBlogPhotos { get; set; }
    }
}
