using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using Tourest.Models.TourTabels;
using Tourest.Models.TourTabels.Tour_Option;


namespace Tourest.Models.VB
{
    public class VbToursLocationCategory
    {
        public int TourId { get; set; }
        public bool isNew { get; set; } = false;
        public decimal? Sale { get; set; } = 0;
        public decimal TourPrice { get; set; }
        public string TourTitel { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
    }
}
