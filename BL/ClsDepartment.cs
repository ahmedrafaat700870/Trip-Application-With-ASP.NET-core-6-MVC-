using Tourest.Models;
using Tourest.Models.TourTabels;
using Microsoft.EntityFrameworkCore;
namespace Tourest.BL
{
    public class ClsDepartment
    {
        public ClsDepartment()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<DepartmentToursModel> GetAllDepartments ()
        {
            try
            {
                return Context.TbDepartmentTour.ToList();
            }
            catch
            {
                return new List<DepartmentToursModel>();
            }
        }
        public bool Add (DepartmentToursModel Department)
        {
            try
            {
                Context.TbDepartmentTour.Add(Department);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(DepartmentToursModel Department)
        {
            try
            {
                Context.Entry(Department).State =EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                Context.TbDepartmentTour.Remove(Context.TbDepartmentTour.Find(id));
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DepartmentToursModel? GetOne(int id)
        {
            try
            {
                var data = (from one in Context.TbDepartmentTour
                            where one.DepartmentTourId == id
                            select one).ToList().FirstOrDefault();
                return data;

            }
            catch
            {
                return new DepartmentToursModel();
            }
        }
    }
}
