using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptScanner.ScannerClient.Helpers
{
     public static class ImageHelper
    {
        public static string ConverImageDataToBase64()
        {
            
            string imageFilePath = "Fis.jpg";

            // resmi base64'e dönüştür
            byte[] imageBytes = File.ReadAllBytes(imageFilePath);
            string imageData = Convert.ToBase64String(imageBytes);
            return imageData;
        }
    }
}
