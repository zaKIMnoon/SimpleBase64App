using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Converter
    {
        //Base 64 from file path
        public static string base64string(string mPath, bool ReturnWithHtml = false)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(mPath);
            var mFileExtension = System.IO.Path.GetExtension(mPath);
            return new library.Converter().base64RawConverter(imageArray, ReturnWithHtml, mFileExtension);   
        }

        //Base 64 from byte array
        public static string base64string(byte[] mbyteArray, string fileExtension, bool ReturnWithHtml = false)
        {
            if (string.IsNullOrEmpty(fileExtension))
            {
                throw new Exception("File Extension required");
            }

            return new library.Converter().base64RawConverter(mbyteArray, ReturnWithHtml,fileExtension);
        }

        //Returns raw base 64
        private string base64RawConverter(byte[] base64Byte, bool ReturnWithHtml, string fileExtension)
        {
            var newBase64String = Convert.ToBase64String(base64Byte);

            if (ReturnWithHtml)
            {
                newBase64String = "data:image/" +fileExtension +";base64," + newBase64String;
            }
            return newBase64String;
        }

    }
}
