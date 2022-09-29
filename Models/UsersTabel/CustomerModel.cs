using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Tourest.Models.CustomsTables
{
    public  class CustomerModel
    {
        public CustomerModel()
        {
        }
        [Key]
        [ValidateNever]
        public int UsersId { get; set; }
        public bool IsAdmin { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
