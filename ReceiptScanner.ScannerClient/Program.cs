using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using ReceiptScanner.ScannerClient.Abstract;
using ReceiptScanner.ScannerClient.Helpers;
using ReceiptScanner.ScannerClient.Model;

namespace ReceiptScanner.ScannerClient
{
    class Program
    {
        public static IServiceCollection _IServiceCollection;
        public static IServiceProvider _IServiceProvider;
        static void Main(string[] args)
        {
            _IServiceCollection = new ServiceCollection();

            _IServiceCollection.ServiceBusinessLayer();

            _IServiceProvider = _IServiceCollection.BuildServiceProvider();

            List<Root> oCRresult = new List<Root>();

            using (IOCRManager ocrService = _IServiceProvider.GetService<IOCRManager>())
            {
                oCRresult = ocrService.GetReceiptJsonFromOcrService();
            }

            var text = StringHelper.AddHeader(oCRresult);

            text = StringHelper.AddLineNumber(text);

            using (ISaveFileManager saveFileManager = _IServiceProvider.GetService<ISaveFileManager>())
            {
                saveFileManager.SaveTxtFile(text);
            }

            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
    }
}
