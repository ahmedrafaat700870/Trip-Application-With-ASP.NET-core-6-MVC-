using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.Blogs
{
    public class BlogPhotoModel
    {
        public BlogPhotoModel()
        {
            TbBlog = new BlogModel();
        }
        [Key]
        [ValidateNever]
        public int BlogPhotoId { get; set; }
        public string BlogPhotoSrc { get; set; }
        public string BlogDescription { get; set; }
        [ValidateNever]
        public int BlogId { get; set; }
        [ValidateNever]
        public BlogModel TbBlog { get; set; }
    }
}
