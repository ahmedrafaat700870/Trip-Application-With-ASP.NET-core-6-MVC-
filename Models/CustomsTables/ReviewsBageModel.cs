using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.CustomsTables
{
    public class ReviewsBageModel
    {
        [Key]
        [ValidateNever]
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50 , ErrorMessage = "Max Length is 50")]
        public string name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Description")]
        public string description { get; set; } = string.Empty;
        public int Like { get; set; } = 0;
        public int disLike { get; set; } = 0;
        public string src { get; set; } = string.Empty;
        public DateTime CretaedDate { get; set; }
    }
}
