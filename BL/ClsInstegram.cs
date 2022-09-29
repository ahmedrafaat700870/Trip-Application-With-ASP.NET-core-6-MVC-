using Tourest.Helper;
using Tourest.Models;
using Tourest.Models.CustomsTables;
namespace Tourest.BL
{

    public class ClsInstegram
    {
        public ClsInstegram()
        {
            Context = new TouristContext();
            oClsImg = new ClsImg();
        }
        private readonly TouristContext Context;
        private readonly ClsImg oClsImg;
        public bool Add(InestegramModel oInestegramModel)
        {
            try
            {
                Context.TbInetegram.Add(oInestegramModel);
                Context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public async Task<bool> Delete(InestegramModel oInestegramModel, string dirName)
        {
            try
            {
                await oClsImg.DeleteFile(dirName, oInestegramModel.PhotoSrc);
                Context.TbInetegram.Remove(oInestegramModel);
                Context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public List<InestegramModel> GetAll()
        {
            try
            {
                return Context.TbInetegram.ToList();
            }
            catch (System.Exception)
            {
                return new List<InestegramModel>();
            }
        }
        public InestegramModel Get(int id)
        {
            try
            {
                return Context.TbInetegram.Find(id);
            }
            catch (System.Exception)
            {
                return new InestegramModel();
            }
        }
    }
}
