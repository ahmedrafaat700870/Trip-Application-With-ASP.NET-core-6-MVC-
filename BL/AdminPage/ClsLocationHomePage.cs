using Tourest.Models;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.AdminPage
{
    public class ClsLocationHomePage
    {
        public ClsLocationHomePage()
        {

            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<LocationHomePage> GetAll ()
        {
            try
            {
                return Context.TbLocationHomePage.ToList();
            }
            catch
            {
                return new List<LocationHomePage>();
            }
        }
    }
}
