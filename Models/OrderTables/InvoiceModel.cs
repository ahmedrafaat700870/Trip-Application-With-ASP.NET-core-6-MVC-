using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Tourest.Models.TourTabels;
using Tourest.Models.CustomsTables;

namespace Tourest.Models.OrderTables
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            TbCustomer = new CustomerModel();
            TbTours = new ToursModel();
        }
        [Key]
        [ValidateNever]
        public int InvoiceId { get; set; }
        [Required(ErrorMessage = "Please enter Price")]
        public decimal Price { set; get; }
        [Required]
        public DateTime InvoiceDate { set; get; }
        [ValidateNever]
        public int CustomerId { get; set; }
        [ValidateNever]
        public CustomerModel TbCustomer { get; set; }
        [ValidateNever]
        public int TourId { get; set; }
        [ValidateNever]
        public ToursModel TbTours { get; set; }
    }
}
