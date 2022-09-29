using Tourest.Models;
using Tourest.Models.OurTeam;

namespace Tourest.BL.HomePage
{
    public class ClsHomeTeamMeamMembers
    {
        public ClsHomeTeamMeamMembers()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<TeamMemberModel> GetAll ()
        {
            try
            {
                return Context.TbTeamMember.ToList();
            }
            catch
            {
                return new List<TeamMemberModel>();
            }
        }


    }
}
