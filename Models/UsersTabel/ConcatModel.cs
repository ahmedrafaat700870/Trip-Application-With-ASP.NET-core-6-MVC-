using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.UsersTabel
{
    public class ConcatModel
    {
        [Key]
        [ValidateNever]
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string FirsName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Your Massage")]
        public string Message { get; set; }
    }
}
