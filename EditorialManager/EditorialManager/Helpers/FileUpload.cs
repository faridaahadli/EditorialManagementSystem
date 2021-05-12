using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Helpers
{
    public static class FileUpload
    {
     
        public static async Task<string> SaveFile(string folder, IFormFile article)
        {
            string filename = Guid.NewGuid().ToString() + "_" + Path.GetFileName(article.FileName);

            string path = Path.Combine(folder, filename);

            using (var stream = new FileStream(path, FileMode.Create))

            {

                await article.CopyToAsync(stream);

            }

            return filename;
        }

      
    }
}
