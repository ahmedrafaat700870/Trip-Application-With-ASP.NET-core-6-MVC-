using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Tourest.Models.TourTabels.Tour_Option
{
    public class ToursOptionModel
    {
        public ToursOptionModel()
        {
            TbTours = new ToursModel();
            TbNeeded = new HashSet<OptionNeedModel>();
            TbIncludded = new HashSet<OptionIncludedModel>();
        }
        [Key]
        [ValidateNever]
        public int TourOptionId { get; set; }
        [Required(ErrorMessage = "Please enter Maximum Number of People")]
        public int? MaxPeople { get; set; } = null;
        [Required(ErrorMessage = "Please enter Minimum Number of People")]
        public int? MinPeople { get; set; } = null;
        [Required(ErrorMessage = "Please enter Max Price")]
        public decimal? Price { get; set; } = null;
        [Required(ErrorMessage = "Please enter Min Age")]
        public int? MinAge { get; set; } = null;
        [Required(ErrorMessage = "Please enter Start Date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid Date")]
        public DateTime? StartDate { get; set; } = null;
        [Required(ErrorMessage = "Please Enter Description")]
        public string OptionDescription { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter End Date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid Date")]
        public DateTime? EndDate { get; set; } = null;
        // Location Table don't Forget
        public int Rate { get; set; } = 3;
        [Required(ErrorMessage = "Please Select day count")]
        public int? DayCount { get; set; } = null;
        [Required(ErrorMessage = "Please Select hour count")]
        public int? HourCount { get; set; } = null;
        public bool isSelected { get; set; }
        [ValidateNever]
        public int TourId { get; set; }
        [ValidateNever]
        public ToursModel TbTours { get; set; }
        public ICollection<OptionNeedModel> TbNeeded { get; set; }
        public ICollection<OptionIncludedModel> TbIncludded { get; set; } 
    }
}
