using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.CustomsTables
{
    public class SectionNamesModel
    {
        [Key]
        [ValidateNever]
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Section Name")]
        public string PopuarSeaction { get; set; }
        [Required(ErrorMessage = "Please Enter Section Name")]
        public string SeaSection { get; set; }
        [Required(ErrorMessage = "Please Enter Section Name")]
        public string InstegramSeaction { get; set; }
        [Required(ErrorMessage = "Please Enter Section Name")]
        public string BlogSeaction { get; set; }
    }
}
