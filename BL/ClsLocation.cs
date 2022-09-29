using Microsoft.AspNetCore.Components.Web;
using Tourest.Models;
using Tourest.Models.TourTabels;
using Microsoft.EntityFrameworkCore;
namespace Tourest.BL
{
    public class ClsLocation
    {
        public ClsLocation() {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public List<LocationModel> GetAllLocation()
        {
            try
            {
                return Context.TbLocation.ToList();
            }
            catch
            {
                return new List<LocationModel>();
            }
        }
        public bool AddLocation (LocationModel Location)
        {
            try
            {
                Context.TbLocation.Add(Location);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdaeLocation (LocationModel Location)
        {
            try
            {
                Context.Entry(Location).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public LocationModel? GetLocationById (int id)
        {
            try
            {
                var data = (from l in Context.TbLocation
                            where l.LocationId == id
                            select l).ToList().FirstOrDefault();
                return data;

            }
            catch
            {
                return new LocationModel();
            }
        }
        public bool Delete (int id)
        {
            try
            {
                Context.TbLocation.Remove(Context.TbLocation.Find(id));
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
