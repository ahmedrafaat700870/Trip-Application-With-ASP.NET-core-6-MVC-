using Tourest.Models;
using Tourest.Models.CustomsTables;
using Microsoft.EntityFrameworkCore;
namespace Tourest.BL.AdminPage
{
    public class ClsNamesSections
    {
        public ClsNamesSections()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
      
        public SectionNamesModel Get()
        {
            try
            {
                return Context.TbSectionNames.ToList().FirstOrDefault();
            } catch
            {
                return new SectionNamesModel();
            }
        }
        public bool UpdateOrEdit(SectionNamesModel oSectionNamesModel)
        {
            try
            {
                if (oSectionNamesModel.id == 0)
                    Context.TbSectionNames.Add(oSectionNamesModel);
                else
                    Context.Entry(oSectionNamesModel).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
