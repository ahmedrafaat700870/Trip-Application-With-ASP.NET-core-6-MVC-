using Tourest.Models.CustomsTables;
using Tourest.Models.OurTeam;

namespace Tourest.BL.HomePage.CustomesModels
{
    public class CusAbout
    {
        public CusAbout()
        {
            Info = new InformationTeamPageModel();
            TeamMembers = new List<TeamMemberModel>();
        }
        public  InformationTeamPageModel Info { get; set; }
        public List<TeamMemberModel> TeamMembers { get; set; }
    }
}
