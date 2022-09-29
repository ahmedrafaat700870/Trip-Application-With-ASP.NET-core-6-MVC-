using Tourest.Models;
using Tourest.Models.UsersTabel;

namespace Tourest.BL.AdminPage
{
    public class ClsConcat
    {
        public ClsConcat()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;

        public bool Add(ConcatModel oConcatModel)
        {
            try
            {
                Context.TbConcat.Add(oConcatModel);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ConcatModel> GetAll()
        {
            try
            {
                return Context.TbConcat.ToList();
            }
            catch
            {
                return new List<ConcatModel>() ;
            }
        }
        public ConcatModel Get(int id)
        {
            try
            {
                return Context.TbConcat.Find(id);
            }
            catch
            {
                return new ConcatModel();
            }
        }
    }
}
