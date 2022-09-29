using Tourest.Models;
using Tourest.Models.TourTabels;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Tourest.Helper;

namespace Tourest.BL.AdminPage
{
    public class ClsPhotoTour
    {
        public ClsPhotoTour()
        {
            Context = new TouristContext();
            oClsImg = new ClsImg();
        }
        private readonly TouristContext Context;
        private readonly ClsImg oClsImg;
        public List<PhotoModel> GetAll(int id)
        {
            try
            {
                return Context.TbPhotos.Where(x => x.TourId == id).ToList();
            }
            catch
            {
                return new List<PhotoModel>();
            }
        }
        public bool SavePhoto(PhotoModel oPhotoModel)
        {
            try
            {
                Context.Database.ExecuteSqlRaw($"INSERT INTO TbPhotos (PhotoSrc ,TourId) VALUES ('{oPhotoModel.PhotoSrc}', {oPhotoModel.TourId});");
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public async Task<bool> RemovePhoto(int id, string dirname)
        {
            try
            {
                var Photo = Context.TbPhotos.Where(x => x.PhotoId == id).ToList().FirstOrDefault();
                bool isDeleted = await oClsImg.DeleteFile(dirname, Photo.PhotoSrc);
                Context.TbPhotos.Remove(Photo);
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
