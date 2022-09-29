using Microsoft.AspNetCore.Mvc;
using System.IO;
using Tourest.BL.AdminPage;
using Tourest.Helper;
using Tourest.Models.CustomsTables;
using Tourest.Models.OurTeam;
namespace Tourest.Areas.Admin.Controllers
{
    [Area("adminToAdminToPanel")]
    public class TeamController : Controller
    {
        public TeamController()
        {
            oTeamMember = new ClsAdminTeamMember();
            oImg = new ClsImg();
        }
        private readonly ClsAdminTeamMember oTeamMember;
        private readonly ClsImg oImg;
        private readonly string DirName = @"wwwRoot//Uploads//Team";
        public IActionResult List()
        {
            return View(oTeamMember.GetAll());
        }
        public IActionResult Add(int id)
        {
            return View(oTeamMember.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(TeamMemberModel oTeam, IFormFile? photo , bool optionsRadios)
        {

            if (!ModelState.IsValid)
                return View("Add", oTeam);
            if (oTeam.TeamMemberPhoto == null && photo == null)
                oTeam.TeamMemberPhoto = String.Empty;
            oTeam.isAdmin = optionsRadios;
            if (oTeam.TeamMeberId == 0)
            {
                // than add new Team Member 
                oTeam.TeamMemberPhoto = await oImg.UploadedFile(photo, DirName);
                oTeamMember.Add(oTeam);
            }
            else
            {
                // then update Team Member .
                if (photo != null)
                {
                    await oImg.DeleteFile(DirName, oTeam.TeamMemberPhoto);
                    oTeam.TeamMemberPhoto = await oImg.UploadedFile(photo, DirName);
                }
                oTeamMember.Update(oTeam);
            }
            return RedirectToAction(actionName:"List");
        }
        public async Task< IActionResult> Delete(int id)
        {
            TeamMemberModel oTeam = oTeamMember.GetById(id);
            await oImg.DeleteFile(DirName, oTeam.TeamMemberPhoto);
            oTeamMember.Delete(oTeam);
            return RedirectToAction(actionName: "List");
        }

        public async Task<IActionResult> UpdateinfoPage()
        {
            return View(oTeamMember.GetPageInfo());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PageSave(InformationTeamPageModel info , IFormFile photo)
        {
            if (!ModelState.IsValid)
                return View("UpdateinfoPage", info);
            if (info.PagePhoto == null && photo == null)
                info.PagePhoto = String.Empty;
            if (info.InfoId == 0)
            {
                // than add new Team Member 
                info.PagePhoto = await oImg.UploadedFile(photo, DirName);
                oTeamMember.AddInof(info);
            }
            else
            {
                // then update Team Member .
                if (photo != null)
                {
                    await oImg.DeleteFile(DirName, info.PagePhoto);
                    info.PagePhoto = await oImg.UploadedFile(photo, DirName);
                }
                oTeamMember.UpdateInfo(info);
            }
            return RedirectToAction(actionName: "Index" , controllerName:"Home");
        }
    }
}
