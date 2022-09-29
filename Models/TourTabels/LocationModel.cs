using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.TourTabels
{
    public class LocationModel
    {
        public LocationModel() {
            TbTour = new HashSet<ToursModel>();
        }
        [Key]
        [ValidateNever]
        public int LocationId { get; set; }
        [Required(ErrorMessage = "Please Enter Location")]
        public string LocationName { get; set; } = string.Empty;
        [ValidateNever]
        public ICollection<ToursModel> TbTour { get; set; }
    }
}
