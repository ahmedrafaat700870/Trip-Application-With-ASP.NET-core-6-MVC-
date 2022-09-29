using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Tourest.Models.HomePage
{
    public class HomePageImages
    {
        [Key]
        [ValidateNever]
        public int HomePageImageId { get; set; }
        [Required]
        public string MainImage { get; set; } = String.Empty;
        [Required]
        public string SubImage1 { get; set; } = String.Empty;
        public string? SubImage2 { get; set; } = String.Empty;
    }
}
