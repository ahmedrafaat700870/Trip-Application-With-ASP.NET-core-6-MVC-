using Microsoft.EntityFrameworkCore;
using Tourest.Helper;
using Tourest.Models;
using Tourest.Models.Blogs;

namespace Tourest.BL.AdminPage
{
    public class ClsBlog
    {
        public ClsBlog()
        {
            Context = new TouristContext();
            Img = new ClsImg();
        }
        private readonly TouristContext Context;
        private readonly ClsImg Img;
        public List<BlogModel> GetAll()
        {
            try
            {
                return Context.TbBlog.Include(i => i.TbBlogPhotos).Select(x => new BlogModel
                {
                    BlogId  = x.BlogId,
                    BlogTitel = x.BlogTitel,
                    TbBlogPhotos = x.TbBlogPhotos ,
                    BlogCreatedBy = x.BlogCreatedBy,
                    BlogCreatedDate = x.BlogCreatedDate,    
                }).ToList();
            }
            catch
            {
                return new List<BlogModel>();
            }
        }
        public bool Add(BlogModel oBlogModel)
        {
            try
            {
                oBlogModel.BlogCreatedDate = DateTime.Now;
                oBlogModel.BlogCreatedDate.ToString("dd/MM/yyyy");
                Context.TbBlog.Add(oBlogModel);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(BlogModel oBlogModel)
        {
            try
            {
                Context.Entry(oBlogModel).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (System.InvalidOperationException e)
            {
                return false;
            }
        }
        public BlogModel GetById(int id)
        {
            try
            {
                return Context.TbBlog
                    .Include(r => r.TbRiviews)
                    .Include(pd =>pd.TbBlogPhotos)
                    .Where(x => x.BlogId == id)
                    .ToList().FirstOrDefault();
            }
            catch
            {
                return new BlogModel();
            }
        }
        public bool Delete(int id)
        {
            try
            {
                Context.TbBlog.Remove(Context.TbBlog.Find(id));
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<BlogPhotoModel> GetAllBlogDescriptionsPhotos(int id)
        {
            try
            {
                return Context.TbBlogDescriptoinPhoto.Where(b => b.BlogId == id).ToList();
            }
            catch
            {
                return new List<BlogPhotoModel>();
            }
        }


        public bool AddPhotoDescription(BlogPhotoModel oBlogPhotoModel , int id)
        {
            try
            {
                Context.Database.ExecuteSqlRaw($"Insert Into TbBlogDescriptoinPhoto Values('{oBlogPhotoModel.BlogPhotoSrc}' , '{oBlogPhotoModel.BlogDescription}' , {id}) ;"); 
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePhotoDescription (BlogPhotoModel oBlogPhoto)
        {
            try
            {
                Context.TbBlogDescriptoinPhoto.Remove(oBlogPhoto);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public BlogPhotoModel GetByIdPhotoDescription(int id)
        {
            try
            {
                return Context.TbBlogDescriptoinPhoto.Find(id);
            }
            catch
            {
                return new BlogPhotoModel();
            }
        }
    }
}
