using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Tourest.Models.CustomsTables
{
    public class InestegramModel
    {
        [Key]
        [ValidateNever]
        public int InstagramId { get; set; }
        [Required(ErrorMessage = "Please enter InstagramSrc")]
        public string InstagramSrc { get; set; }
        [Required(ErrorMessage = "Please enter PhotoSrc")]
        public string PhotoSrc { get; set; }
    }
}
