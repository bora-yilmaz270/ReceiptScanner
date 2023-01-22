using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReceiptScanner.ScannerClient.Abstract;
using ReceiptScanner.ScannerClient.Helpers;
using ReceiptScanner.ScannerClient.Model;

namespace ReceiptScanner.ScannerClient.Concreate
{
    public class OCRManager: IOCRManager
    {
        #region Variables
        private string apiBaseAddress = "https://localhost:44303/";
        #endregion

        private HttpClient OCRConnection()
        {
           
                var client = new HttpClient();
                client.BaseAddress = new Uri(apiBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;

        }
        public List<Root> GetReceiptJsonFromOcrService()
        {
            var imageData = ImageHelper.ConverImageDataToBase64();
            var client= OCRConnection();
            var content = new StringContent(imageData);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync("api/Image/ProcessImage", content).Result;
            // json verisini al
            var jsonString = response.Content.ReadAsStringAsync().Result;
            List<Root> result = JsonConvert.DeserializeObject<List<Root>>(jsonString);
            return result;
        }





        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
