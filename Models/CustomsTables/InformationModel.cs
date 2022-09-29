using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Tourest.Models.CustomsTables
{
    public class InformationModel
    {
        //public InformationModel(){}
        [Key]
        [ValidateNever]
        public int InformationId { get; set; }
        [Required(ErrorMessage = "This Filed Required")]
        [RegularExpression("^(\\+\\d{1,2}\\s?)?1?\\-?\\.?\\s?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string InformationPhone { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a valid email")]
        [EmailAddress(ErrorMessage = "Please enter Valid  email")]
        public string InformationEmail { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a FaceBook Account")]
        public string FaceBookAccount { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Twitter Account")]
        public string TwitterAcount { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Instagram address")]
        public string InstagramAccount { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please Enter Web Site Name")]
        public string WebSiteName{ get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Description")]
        public string DescriptionInfo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Chose Logo Image")]
        public string LogoImage { get; set; } = string.Empty;
        public string FooterDescription { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Footer Image")]
        public string FooterImage { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Location Andres")]
        public string Location { get; set; } = string.Empty;
        public string? Facx { get; set; } = string.Empty;

    }
}
