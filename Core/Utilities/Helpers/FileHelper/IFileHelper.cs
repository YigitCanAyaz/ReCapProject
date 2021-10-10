using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        public IResult Upload(IFormFile file);
        public IResult Update(IFormFile file, string imagePath);
        public IResult Delete(string path);
    }
}
