
using Tourest.Helper;
using Tourest.Models;
using Tourest.Models.TourTabels;
using Microsoft.EntityFrameworkCore;

namespace Tourest.BL.AdminPage
{
    public class ClsPhoto
    {
        public ClsPhoto()
        {
            oClsImg = new ClsImg();
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        private readonly ClsImg oClsImg;
        private readonly string SrcFile = @"wwwRoot//Uploads//Tours";
        public List<string> GetAllPhoto(int id)
        {
            try
            {
                var Photos = 
                    from f in Context.TbPhotos
                    where f.TourId == id
                    select f;
                return Photos.Select(s => s.PhotoSrc).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }
        public async Task<bool> AddPhotoes(List<IFormFile> files, int id)
        {
            try
            {
                foreach (var file in files)
                {
                    string fileName = await oClsImg.UploadedFile(file, SrcFile);
                    Context.Database.ExecuteSqlRaw($"INSERT INTO TbPhotos (PhotoSrc ,TourId) VALUES ('{fileName}' , '{id}')");
                    Context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<IFormFile> listFiles(IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4, IFormFile file5, IFormFile file6)
        {
            List<IFormFile> fis = new List<IFormFile>();
            if (file1 != null)
                fis.Add(file1);
            if (file2 != null)
                fis.Add(file2);
            if (file3 != null)
                fis.Add(file3);
            if (file4 != null)
                fis.Add(file4);
            if (file5 != null)
                fis.Add(file5);
            if (file6 != null)
                fis.Add(file6);

            return fis;
        }

    }
}
