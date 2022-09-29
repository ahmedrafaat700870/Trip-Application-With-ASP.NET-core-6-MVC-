using Microsoft.AspNetCore.Mvc;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.BL.AdminPage
{
    public class ClsNeeded
    {
        public ClsNeeded()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<OptionNeedModel> GetAll (int id)
        {
            try
            {
                return Context.TbOptionNeeded.Where(x => x.OptionId == id).ToList();
            }
            catch
            {
                return new List<OptionNeedModel>();
            }
        }
        public bool Add(string Name , int id)
        {
            try
            {
                OptionNeedModel oOptionNeedModel = new OptionNeedModel
                {
                    OptionId = id,
                    tourNeededName = Name ,
                    TbOption = null
                };
                Context.TbOptionNeeded.Add(oOptionNeedModel);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete( int id)
        {
            try
            {
                Context.TbOptionNeeded.Remove(Context.TbOptionNeeded.Find(id));
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
