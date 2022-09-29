using System.Diagnostics;
using Tourest.Models.TourTabels;

namespace Tourest.BL.CustomeModel
{
    public class CusPhotosTour
    {
        public CusPhotosTour()
        {
            TbPhoto = new PhotoModel();
            TbPhotos = new List<PhotoModel> ();
        }
        public PhotoModel TbPhoto;
        public List<PhotoModel> TbPhotos;
    }
}
