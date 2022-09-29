using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Diagnostics.CodeAnalysis;

namespace Tourest.Helper
{
    public class ClsImg
    {
        public async Task<string> UploadedFile(IFormFile file, string dirname)
        {
            
            if (file != null)
            {
                try
                {
                    string fileName = Guid.NewGuid().ToString() + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ".jpg";
                    string path = Path.Combine(Directory.GetCurrentDirectory(), dirname, fileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return fileName;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return string.Empty;
        }
        public async Task<bool> DeleteFile(string dirname, string filename)
        {
            try
            {
                if (filename != null)
                {
                    string filepath = Path.Combine(Directory.GetCurrentDirectory(), dirname, filename);
                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteFiles(string dirname, List<string> filenames)
        {
            try
            {
                string filepath = string.Empty;
                foreach (var filename in filenames)
                {
                    filepath = Path.Combine(Directory.GetCurrentDirectory(), dirname, filename);
                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
