using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Tourest.BL.CustomeModel;
using Tourest.Models.Blogs;
using Tourest.Models.TourTabels;
using Tourest.Models.UsersTabel;

namespace Tourest.Models.CustomsTables
{
    public class ReviewsModel
    {
        public ReviewsModel()
        {
/*            TbTours = new ToursModel();
            TbCustomer = new CustomerModel();*/
            TbBlog = new BlogModel();
        }
        [Key]
        [ValidateNever]
        public int ReviewId { get; set; }
        [Required(ErrorMessage = "Please enter your review Title")]
        public string Name { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter your review Rate")]
        public string ReviewDescription { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter your Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        public string Email { get; set; } = String.Empty;
        public DateTime ReviewDate { get; set; }
        [ValidateNever]
        public int? TourId  { get; set; }
        [ValidateNever]
        public ToursModel TbTours { get; set; }
        [ValidateNever]
        public int? CustomerId { get; set; }
        [ValidateNever]
        public CustomerModel TbCustomer { get; set; }
        [ValidateNever]
        public int? BlogId { get; set; }
        [ValidateNever]
        public BlogModel TbBlog { get; set; }

    }
}
