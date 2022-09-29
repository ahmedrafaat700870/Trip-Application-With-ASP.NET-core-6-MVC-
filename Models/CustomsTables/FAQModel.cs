using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.CustomsTables
{
    public class FAQModel
    {
        [Key]
        [ValidateNever]
        public int id { get; set; }
        public string question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
    }
}
