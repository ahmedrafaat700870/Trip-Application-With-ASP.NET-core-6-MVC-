using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Tourest.Models.TourTabels
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            TbTours = new HashSet<ToursModel>();
        }
        [Key]
        [ValidateNever]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please enter Department Name")]
        public string CategoryName { get; set; } = string.Empty;
        [ValidateNever]
        public ICollection<ToursModel> TbTours { get; set; }
    }
}
