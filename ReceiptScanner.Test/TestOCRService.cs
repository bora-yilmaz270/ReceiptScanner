using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptScanner.OCRService.Controllers;
using ReceiptScanner.OCRService.Model;

namespace ReceiptScanner.Test
{
    [TestClass]
    public class TestOCRService
    {
        [TestMethod]
        public void Test_ProcessImage()
        {
          
            var imageController = new ImageController();
            var imageFileBase64Data = "Test Data";

           
            var result = imageController.ProcessImage(imageFileBase64Data) as OkObjectResult;

        
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Value, typeof(List<Root>));
        }

    }
}
