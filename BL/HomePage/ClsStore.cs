using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.BL.HomePage
{
    public class ClsStore
    {
        public ClsStore()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<ToursModel> GetRigthTours()
        {
            try
            {
                return Context.TbTours.
                    Include(x => x.TbPhotos).
                    Include(x => x.TbTourOptions).
                    ToList().ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
        public List<ToursModel> SrechTours(int CategoryId, int LocatoinId)
        {
            try
            {
                if (CategoryId != 0 && CategoryId != null)
                {
                    return Context.TbTours.Where(x => x.CategoryId == CategoryId).ToList();
                }
                else if (LocatoinId != 0 && LocatoinId != null)
                {
                    return Context.TbTours.Where(x => x.LocationId == LocatoinId).ToList();
                }
                else
                {
                    return Context.TbTours.ToList();
                }
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
        public List<ToursModel> SearchById(int CategoryId, int LocationId)
        {
            try
            {
                return Context.TbTours
                .Where(x => (x.CategoryId == CategoryId || CategoryId == null || CategoryId == 0)
                &&  (x.LocationId == LocationId || LocationId == null || LocationId == 0))
                .ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
        public List<ToursModel> Search(string? Search)
        {
            try
            {
                return Context.TbTours
                .Where(x =>(x.TourTitel.Contains(Search) || Search == null || Search == string.Empty)
                && (x.TourTitel.Contains(Search) || Search == null || Search == string.Empty)).ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }

    }
}
