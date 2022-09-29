using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.AdminPage
{
    public class ClsFAQ
    {
        public ClsFAQ()
        {
            Context = new TouristContext();
        }

        #region Property
        private readonly TouristContext Context;
        #endregion


        #region Methods

        public bool Add(FAQModel oFAQ)
        {
            try
            {
                Context.TbFAQ.Add(oFAQ);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<FAQModel> GetAll()
        {
            try
            {
                return Context.TbFAQ.ToList();
            }
            catch
            {
                return new List<FAQModel>();
            }
        }
        public bool Update(FAQModel oFAQModel)
        {
            try
            {
                Context.Entry(oFAQModel).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public FAQModel GetById(int id)
        {
            try
            {
                return Context.TbFAQ.Find(id);
            }
            catch
            {
                return new FAQModel();
            }
        }
        public bool Delete(FAQModel oFAQ)
        {
            try
            {
                Context.TbFAQ.Remove(oFAQ);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
