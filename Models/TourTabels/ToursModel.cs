using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Tourest.Models.CustomsTables;
using Tourest.Models.OrderTables;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.Models.TourTabels
{
    public class ToursModel
    {
        public ToursModel()
        {
            TbTourOptions = new HashSet<ToursOptionModel>();
            TbPhotos = new HashSet<PhotoModel>();
            TbInvoices = new HashSet<InvoiceModel>();
            TbReviews = new HashSet<ReviewsModel>();
            TbCategory = new CategoryModel();
            TbLocation = new LocationModel();
            TbDepartmentTour = new HashSet<DepartmentToursModel>();
            TbLocationHomePage = new LocationHomePage();
        }
        [Key]
        [ValidateNever]
        public int TourId { get; set; }
        [Required(ErrorMessage = "Please enter is New Filed")]


        [ValidateNever]
        public bool isNew { get; set; } = false;

        public decimal? Sale { get; set; } = 0;

        [Required(ErrorMessage = "Please enter Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter Tour Price")]
        public decimal TourPrice { get; set; }
        [Required(ErrorMessage = "Please Enter Tour Titel")]
        public string TourTitel { get; set; }
        [ValidateNever]
        public DateTime CreatedDate { get; set; }
        [ValidateNever]
        public bool isDeleted { get; set; } = false;
        public string? VideoSrc { get; set; } = string.Empty;
        [ValidateNever]
        public ICollection<ToursOptionModel> TbTourOptions { get; set; } 
        [ValidateNever]
        public ICollection<PhotoModel> TbPhotos { get; set; } 
        [ValidateNever]
        public int CategoryId { get; set; }
        [ValidateNever]
        public CategoryModel TbCategory { get; set; } = null!;
        [ValidateNever]
        public ICollection<ReviewsModel> TbReviews { get; set; }
        [ValidateNever]
        public ICollection<InvoiceModel> TbInvoices { get; set; } 
        [ValidateNever]
        public int LocationId { get; set; }
        [ValidateNever]
        public LocationModel TbLocation { get; set; } = null!;
        [ValidateNever]
        public ICollection<DepartmentToursModel> TbDepartmentTour { get; set; }
        [ValidateNever]
        public int? LocationHomePageId { get; set; } = null!;
        [ValidateNever]
        public LocationHomePage? TbLocationHomePage { get; set; } = null!;
    }
}
