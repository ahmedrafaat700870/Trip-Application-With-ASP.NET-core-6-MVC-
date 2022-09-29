using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.TourTabels
{
    public class DepartmentModel
    {
        public DepartmentModel()
        {
            TbDepartmentTour = new HashSet<DepartmentToursModel>();
        }
        [Key]
        [ValidateNever]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please Enter Department Name")]
        public string DepartmentName { get; set; } = null;
        [ValidateNever]
        public ICollection<DepartmentToursModel> TbDepartmentTour { get; set; }
    }
}
