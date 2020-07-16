using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JewelryMaking.Services
{
    public class FileUploadService
    {
        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {

            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;

        }
        public byte[] GetFile(Bead file)
        {
            if (file == null)
                return new byte[0];
            else
                return file.File;
        }
    }
}