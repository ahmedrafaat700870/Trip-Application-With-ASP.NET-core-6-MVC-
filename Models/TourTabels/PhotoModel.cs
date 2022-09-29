using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Tourest.Models.TourTabels
{
    public class PhotoModel
    {
        public PhotoModel()
        {
            TbTours = new ToursModel();
        }
        [Key]
        [ValidateNever]
        public int PhotoId { get; set; }
        [Required(ErrorMessage = "Please enter Photo Src")]
        public string PhotoSrc { get; set; }
        [ValidateNever]
        public int TourId { get; set; }
        [ValidateNever]
        public ToursModel TbTours { get; set; }
    }
}
