using System;
using System.Collections.Generic;

namespace Tourest.Models.TourTabels
{
    public partial class DepartmentToursModel
    {
        public int DepartmentTourId { get; set; }
        public int DepartmentId { get; set; }
        public int TourId { get; set; }

        public virtual DepartmentModel Department { get; set; } = null!;
        public virtual ToursModel Tour { get; set; } = null!;
    }
}
