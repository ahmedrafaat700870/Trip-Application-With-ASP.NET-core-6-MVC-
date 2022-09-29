using Microsoft.EntityFrameworkCore;
using Tourest.Models;
using Tourest.Models.CustomsTables;

namespace Tourest.BL.AdminPage
{
    public class ClsInformation
    {
        public ClsInformation()
        {
            Context = new TouristContext();
        }

        #region Property
        private readonly TouristContext Context;
        #endregion


        #region Methods
        public bool UpdateInformation(InformationModel oInformationModel)
        {
            try
            {
                Context.Entry(oInformationModel).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public InformationModel GetInformation()
        {
            try
            {
                var data = Context.TbInformation.ToList().FirstOrDefault();
                if (data == null)
                    return new InformationModel();
                return data;
            }
            catch
            {
                return new InformationModel();
            }
        }
        public InformationModel HeaderInformation()
        {
            try
            {
                var data = Context.TbInformation.ToList().FirstOrDefault();

                if (data == null)
                    return new InformationModel();
                return data;
            }
            catch
            {
                return new InformationModel();
            }
        }
        #endregion
    }
}
