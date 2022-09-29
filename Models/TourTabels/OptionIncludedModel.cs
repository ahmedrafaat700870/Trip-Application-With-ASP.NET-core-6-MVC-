using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.Models.TourTabels
{
    public class OptionIncludedModel
    {
        public OptionIncludedModel()
        {
            TbOption = new ToursOptionModel();
        }
        [Key]
        [ValidateNever]
        public int IncludedId { get; set; }
        [Required(ErrorMessage = "this filed Required")]
        public string IncludedName { get; set; } = String.Empty;
        public bool isIncluded { get; set; } = false;
        [ValidateNever]
        public int OptionId { get; set; }
        [ValidateNever]
        public ToursOptionModel TbOption { get; set; }
    }
}
