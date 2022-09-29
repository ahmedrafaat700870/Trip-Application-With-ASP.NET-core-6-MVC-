using Tourest.Models;
using Tourest.Models.TourTabels;
using Microsoft.EntityFrameworkCore;

namespace Tourest.BL.AdminPage
{
    public class ClsCategory
    {
        public ClsCategory()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<CategoryModel> GetAllCategory()
        {
            try
            {
                return Context.TbCategores.ToList();
            }
            catch
            {
                return new List<CategoryModel>();
            }
        }
        public bool Add(CategoryModel oCategory)
        {
            try
            {
                Context.TbCategores.Add(oCategory);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(CategoryModel oCategores)
        {
            try
            {
                Context.Entry(oCategores).State = EntityState.Modified;
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
                Context.TbCategores.Remove(Context.TbCategores.Find(id));
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CategoryModel? GetOne(int id)
        {
            try
            {
                var data = (from one in Context.TbCategores
                            where one.CategoryId == id
                            select one).ToList().FirstOrDefault();
                return data;

            }
            catch
            {
                return new CategoryModel();
            }
        }
    }
}
