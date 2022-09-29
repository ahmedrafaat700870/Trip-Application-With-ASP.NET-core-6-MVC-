using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using Tourest.Models.TourTabels;

namespace Tourest.Models.CustomsTables
{
    public class LocationHomePage
    {
        public LocationHomePage()
        {
            TbTours = new HashSet<ToursModel>();
        }
        [Key]
        [ValidateNever]
        public int LocationHomePageId { get; set; }
        [Required(ErrorMessage = "Please Enter Location In Home Page")]                      
        public string LocationName { get; set; }
        [ValidateNever]
        public ICollection<ToursModel> TbTours { get; set; }
    }
}
