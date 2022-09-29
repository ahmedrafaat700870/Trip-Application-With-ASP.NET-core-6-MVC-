using System;
using System.Collections.Generic;
using Tourest.Models.TourTabels;

namespace test.Models
{
    public partial class TbTourOption
    {
        public TbTourOption()
        {
      /*      TbCustomerTourOptions = new HashSet<TbCustomerTourOption>();*/
        }

        public int TourOptionId { get; set; }
        public int MaxPeople { get; set; }
        public int MinPeople { get; set; }
        public decimal Price { get; set; }
        public int MinAge { get; set; }
        public DateTime StartDate { get; set; }
        public string OptionDescription { get; set; } = null!;
        public DateTime EndDate { get; set; }
        public int Rate { get; set; }
        public int DayCount { get; set; }
        public int HourCount { get; set; }
        public bool IsSelected { get; set; }
        public int TourId { get; set; }

        public virtual ToursModel Tour { get; set; } = null!;
    /*    public virtual ICollection<TbCustomerTourOption> TbCustomerTourOptions { get; set; }*/
    }
}
