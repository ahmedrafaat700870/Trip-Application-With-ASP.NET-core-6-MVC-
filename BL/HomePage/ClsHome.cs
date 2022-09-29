using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.TourTabels;

namespace Tourest.BL.HomePage
{
    public class ClsHome
    {
        public ClsHome()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<ToursModel> GetNewTours()
        {
            try
            {
                var data = Context.TbTours.FromSqlRaw("select top 6 * from dbo.TbTours order by  CreatedDate desc ;");
                return data.ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
        public List<ToursModel> GetAllTours()
        {
            try
            {
                var data = Context.TbTours
                    .Include(p => p.TbPhotos)
                    .Include(o => o.TbTourOptions)
                    .ToList();
                return data;
            }
            catch
            {
                return new List<ToursModel>();

            }
        }
        public ToursModel? GetTourById(int id)
        {
            try
            {
                return Context.TbTours.Where(x => x.TourId == id).ToList().FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<ToursModel>? GetToursMinPrcie()
        {
            try
            {
                return Context.TbTours.OrderByDescending(x => x.TourPrice).Take(6).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<ToursModel>? GetToursMaxPrcie()
        {
            try
            {
                return Context.TbTours.OrderBy(x => x.TourPrice).Take(6).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<ToursModel> GetToursByMaxDays()
        {
            try
            {
                var data = (
                    from t in Context.TbTours
                    join o in Context.TbTourOption
                    on t.TourId equals o.TourId
                    orderby o.DayCount
                    select t).ToList();
                return data;
            }
            catch
            {
                return new List<ToursModel>();
            }
        }
    }
}
