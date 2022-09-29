using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.OurTeam
{
    public class TeamMemberModel
    {
        [Key]
        [ValidateNever]
        public int TeamMeberId { get; set; }
        [Required(ErrorMessage ="Please Enter Team Member Name")]
        public string TeamMeberName { get; set; } = string.Empty;
        [ValidateNever]
        public string TeamMemberPhoto { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Team Member Job")]
        public string TeamMebmerJob { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Team Member Job Description")]
        public string TeamMemberJobDescription { get; set; } = string.Empty;
        public bool isAdmin { get; set; } = false;
    }
}
