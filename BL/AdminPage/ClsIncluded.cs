using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.BL.AdminPage
{
    public class ClsIncluded
    {
        public ClsIncluded()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<OptionIncludedModel> GetAll (int id)
        {
            try
            {
                return Context.TbbOptionIncluded.Where(x => x.OptionId == id).ToList();
            }
            catch
            {
                return new List<OptionIncludedModel>();
            }
        }
        public bool Add(string Name , int id , bool isInlucded)
        {
            try
            {
                OptionIncludedModel oOptionIncludedModel = new OptionIncludedModel
                {
                    OptionId = id,
                    IncludedName = Name,
                    isIncluded = isInlucded,
                    TbOption = null
                };
                Context.TbbOptionIncluded.Add(oOptionIncludedModel);
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
                Context.TbbOptionIncluded.Remove(Context.TbbOptionIncluded.Find(id));
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
