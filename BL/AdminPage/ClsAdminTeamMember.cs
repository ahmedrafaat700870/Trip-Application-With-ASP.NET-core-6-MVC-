using Tourest.Models;
using Tourest.Models.OurTeam;
using Microsoft.EntityFrameworkCore;
using Tourest.Models.CustomsTables;
using System.IO;

namespace Tourest.BL.AdminPage
{
    public class ClsAdminTeamMember
    {
        public ClsAdminTeamMember()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<TeamMemberModel> GetAll()
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

        public bool Add (TeamMemberModel oTeam)
        {
            try
            {
                Context.TbTeamMember.Add(oTeam);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(TeamMemberModel oTeam)
        {
            try
            {
                
                Context.Entry(oTeam).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public TeamMemberModel GetById(int id)
        {
            try
            {
                if (id == 0)
                    throw new Exception();
                return Context.TbTeamMember.Find(id);
            }
            catch
            {
                return new TeamMemberModel();
            }
        }
        public bool Delete (TeamMemberModel oTeam)
        {
            try
            {
                Context.TbTeamMember.Remove(oTeam);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public InformationTeamPageModel GetPageInfo ()
        {
            try
            {
                return Context.TbInfoTeamPage.ToList().FirstOrDefault();
            }
            catch
            {
                return new InformationTeamPageModel();
            }
        }

        public bool AddInof (InformationTeamPageModel info)
        {
            try
            {
                Context.TbInfoTeamPage.Add(info);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateInfo(InformationTeamPageModel info)
        {
            try
            {

                Context.Entry(info).State = EntityState.Modified;
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
