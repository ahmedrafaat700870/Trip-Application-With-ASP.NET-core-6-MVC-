using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tourest.BL.CustomeModel;
using Tourest.Models;
using Tourest.Models.TourTabels.Tour_Option;

namespace Tourest.BL.AdminPage
{

    public class ClsOption
    {
        public ClsOption()
        {
            Context = new TouristContext();
        }
        private readonly TouristContext Context;
        public bool Add(ToursOptionModel oTourOptionModel , int rating , bool wifi)
        {
            try
            {
                /* Context.Database.ExecuteSqlRaw($"INSERT INTO TbTourOption VALUES ({oTourOptionModel.MaxPeople} , {oTourOptionModel.Price} , {oTourOptionModel.MinAge}  , '{oTourOptionModel.StartDate}' , '{oTourOptionModel.EndDate}' , {oTourOptionModel.TourId} , {oTourOptionModel.MinPeople} , '{oTourOptionModel.OptionDescription}' , '{oTourOptionModel.Rate}' , '{oTourOptionModel.isSelected}' , {oTourOptionModel.DayCount}, {oTourOptionModel.HourCount})");
                */
                oTourOptionModel.Rate = rating;
                oTourOptionModel.isSelected = wifi;
                oTourOptionModel.TbTours = null;
                Context.TbTourOption.Add(oTourOptionModel);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ToursOptionModel> GetAll(int id)
        {
            try
            {
                // this will update last
                var Data = Context.TbTourOption.Where(x =>x.TourId == id).ToList();
                return Data;
            }
            catch
            {
                return new List<ToursOptionModel>();
            }
        }
        public ToursOptionModel GetById(int? id)
        {
            try
            {
                var option = (from o in Context.TbTourOption
                              where o.TourOptionId == id
                              select o).ToList().FirstOrDefault();
                return option;
            }
            catch
            {
                return new ToursOptionModel();
            }
        }
        public bool Update(ToursOptionModel oTourOption)
        {
            try
            {
                Context.Entry(oTourOption).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                Context.TbTourOption.Remove(Context.TbTourOption.Where(o => o.TourOptionId == id).ToList().FirstOrDefault());
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
