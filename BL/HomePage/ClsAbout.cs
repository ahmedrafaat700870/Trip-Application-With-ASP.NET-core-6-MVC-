using Tourest.BL.HomePage.CustomesModels;
using Tourest.Models;

namespace Tourest.BL.HomePage
{
    public class ClsAbout
    {
        public ClsAbout()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public CusAbout GetAll()
        {
            try
            {
                return new CusAbout
                {
                    Info = Context.TbInfoTeamPage.ToList().FirstOrDefault(),
                    TeamMembers = Context.TbTeamMember.ToList()
                }; 
            }
            catch
            {
                return new CusAbout();
            }
        }
    }
}
