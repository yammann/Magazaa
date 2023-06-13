using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business.Methods
{
   public class ImageMethod
    {
        public MemoryStream memoryStream=new MemoryStream();
        public byte[] by;

        public byte[] ConvertToByte()
        {
            return memoryStream.ToArray();
        }
        public MemoryStream ConvertToImage()
        {
            memoryStream=new MemoryStream(by);
            return memoryStream;
        }
    }
}
