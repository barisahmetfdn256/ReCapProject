using Core.Utilites.Helper.GUIDHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilites.Helper.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

            }

        }

        public string Update(IFormFile formFile, string root, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

            }
            return Upload(formFile, root);
        }

        public string Upload(IFormFile formFile, string root)
        {
            if (formFile.Length > 0 )
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(formFile.FileName);
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + extension;
                using (FileStream fs = File.Create(root + filePath))
                {
                    formFile.CopyTo(fs);
                    fs.Flush();
                    return filePath;
                }
            }
            return null;
        }
    }
}
