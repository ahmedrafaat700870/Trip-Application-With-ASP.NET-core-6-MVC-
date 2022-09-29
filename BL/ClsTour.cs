using Microsoft.EntityFrameworkCore;
using Tourest.BL.CustomeModel;
using Tourest.Helper;
using Tourest.Models;
using Tourest.Models.TourTabels;
using Tourest.Models.VB;

namespace Tourest.BL.AdminPage
{

    public class ClsTourAdmin
    {
        public ClsTourAdmin()
        {
            Context = new TouristContext();
            Img = new ClsImg();
        }
        private readonly TouristContext Context;
        private readonly ClsImg Img;
        public List<ToursModel> GetAllTours()
        {
            try
            {
                return Context.TbTours.ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }




        public ToursModel GetById(int id)
        {
            try
            {
                if (id == 0) // add new tour
                    throw new Exception();
                var data = Context.TbTours.Find(id);
                return data; // update
            }
            catch
            {
                return new ToursModel();
            }
        }
        public bool Add(ToursModel oTourModel)
        {
            try
            {
                oTourModel.TbCategory = null;
                oTourModel.TbLocation = null;
                oTourModel.TbLocationHomePage = null;
                Context.TbTours.Add(oTourModel);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public ToursModel GetTourById(int id)
        {
            try
            {
                return Context.TbTours.Find(id);
            }
            catch
            {
                return new ToursModel();
            }
        }
        public bool Update(ToursModel oToursModel)
        {
            try
            {
                Context.Entry(oToursModel).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteTour(int id)
        {
            try
            {
                Context.TbTours.Remove(GetTourById(id));
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ToursModel> GetJoinTours()
        {
            try
            {
                return Context.TbTours
                    .Include(x => x.TbLocation)
                    .Include(y => y.TbCategory)
                    .ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
        public List<VbToursLocationCategory> GetAllToursLocatoinCategory()
        {
            try
            {
                var data = Context.VbToursLocationCategory.ToList();
                if (data == null)
                    throw new Exception();
                return data;
            }
            catch
            {
                return new List<VbToursLocationCategory>();
            }
        }
        public async Task< bool >Delete (int id , string dirname)
        {
            try
            {
                // get all photo by id
                var Photos = Context.TbPhotos.Select(x => new PhotoModel { 
                PhotoSrc = x.PhotoSrc,
                TourId = x.TourId
                }).Where(x => x.TourId == id).ToList();
                foreach(var photo in Photos)
                {
                    // delete photo from uploads file 
                    await Img.DeleteFile(dirname, photo.PhotoSrc);
                }
                // delete tour from database 
                DeleteTour(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<VbToursLocationCategory> Search (int? CategoryId , int? LocatoinId)
        {
            try
            {
                // get all photo by id

                return Context.VbToursLocationCategory.Where(x => (x.CategoryId == CategoryId || CategoryId == null || CategoryId == 0)
                && (x.LocationId == LocatoinId || LocatoinId == null || LocatoinId == 0 )
                ).ToList();

            }
            catch
            {
                return new List<VbToursLocationCategory>() ;
            }
        }
    }
}
