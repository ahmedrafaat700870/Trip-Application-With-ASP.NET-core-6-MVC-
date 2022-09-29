using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.CustomsTables
{
    public class InformationTeamPageModel
    {
        [Key]
        [ValidateNever]
        public int InfoId { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter title")]
        public string PageTitel { get; set; } = string.Empty;
        [ValidateNever]
        public string PagePhoto { get; set; } = string.Empty;
    }
}
