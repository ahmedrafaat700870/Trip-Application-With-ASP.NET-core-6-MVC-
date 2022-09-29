using Microsoft.EntityFrameworkCore;
using Tourest.BL.HomePage.CustomesModels;
using Tourest.Models;
using Tourest.Models.TourTabels;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.BL.HomePage
{
    public class ClsItem
    {
        public ClsItem()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public ToursModel GetById(int id)
        {
            try
            {
                return Context.TbTours.
                    Where(x => x.TourId == id)
                    .Include(x => x.TbPhotos)
                    .Include(x =>x.TbTourOptions)
                    .Include(x => x.TbLocation)
                    .ToList().FirstOrDefault();
            }
            catch
            {
                return new ToursModel();
            }
        }
        public ToursOptionModel GetOption (int id)
        {
            try
            {
                var data = Context.TbTourOption.Where(x => x.TourOptionId == id)
                    .Include(x => x.TbIncludded)
                    .Include(x => x.TbNeeded)
                    .ToList().FirstOrDefault();
                return data;
            }
            catch
            {
                return new ToursOptionModel();
            }
        }
        public ToursOptionModel GetAllOption(int id)
        {
            try
            {
                var data = Context.TbTourOption.Where(x => x.TourId == id)
                    .Include(x => x.TbIncludded)
                    .Include(x => x.TbNeeded)
                    .ToList().FirstOrDefault();
                return data;
            }
            catch
            {
                return new ToursOptionModel();
            }
        }
        public List<ToursModel> GetRelatedTours(int CategoryId)
        {
            try
            {
                return Context.TbTours
                .Where(x => x.CategoryId == CategoryId)
                .Include(x => x.TbPhotos)
                .Include(x => x.TbTourOptions)
                .ToList();
            }
            catch
            {
                return new List<ToursModel>();
            }
        }

        public CusItem GetItem(int id ,int TourOptionId)
        {
            try
            {
                CusItem cusItem;
                if (TourOptionId == 0)
                {

                    cusItem = new CusItem
                    {
                        MainTour = GetById(id),
                        TourtOption = GetAllOption(id),
                    };
                } else
                {
                    cusItem = new CusItem
                    {
                        MainTour = GetById(id),
                        TourtOption = GetOption(TourOptionId),
                    };
                }

                cusItem.ToursRelated = GetRelatedTours(cusItem.MainTour.CategoryId);
                if (cusItem.TourtOption == null)
                    cusItem.TourtOption = new ToursOptionModel();
                return cusItem;
            }
            catch
            {
                return new CusItem();
            }
        }
    }
}
