using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.Models.TourTabels
{
    public class OptionNeedModel
    {
        public OptionNeedModel()
        {
            TbOption = new ToursOptionModel();
        }

        [Key]
        [ValidateNever]
        public int NeedId { get; set; }
        [Required(ErrorMessage = "Please enter Tour Needed")]
        public string tourNeededName { get; set; } = String.Empty;
        [ValidateNever]
        public int OptionId { get; set; }
        [ValidateNever]
        public ToursOptionModel TbOption  { get; set; }
    }
}
