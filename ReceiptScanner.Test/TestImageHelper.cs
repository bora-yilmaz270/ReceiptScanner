using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptScanner.ScannerClient.Helpers;

namespace ReceiptScanner.Test
{
    [TestClass]
    public class TestImageHelper
    {
        [TestMethod]
        public void ConvertImageDataToBase64_ReturnsExpectedOutput()
        {
            
            string imageFilePath = "Fis.jpg";
            byte[] imageBytes = File.ReadAllBytes(imageFilePath);
            string expectedImageData = Convert.ToBase64String(imageBytes);

           
            string actualImageData = ImageHelper.ConverImageDataToBase64();

         
            Assert.AreEqual(expectedImageData, actualImageData);
        }
    }
}
