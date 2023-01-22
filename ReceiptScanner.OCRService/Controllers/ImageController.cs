using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReceiptScanner.OCRService.Model;

namespace ReceiptScanner.OCRService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        [Route("ProcessImage")]
        public IActionResult ProcessImage(string imageFileBase64Data)
        {
            string jsonFilePath = "response.json";
            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();
                var jsonObject = JsonConvert.DeserializeObject<List<Root>>(json);
                return Ok(jsonObject);
            }
        }
    }
}
