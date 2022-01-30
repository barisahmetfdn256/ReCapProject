using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Helper.FileHelper
{
    public interface IFileHelper
    {
        string Update(IFormFile formFile, string root , string filePath);
        string Upload(IFormFile formFile , string root);
        void Delete(string filePath);
       
    }
}
