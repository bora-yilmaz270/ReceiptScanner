using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ReceiptScanner.ScannerClient.Abstract;
using ReceiptScanner.ScannerClient.Concreate;

namespace ReceiptScanner.ScannerClient
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ServiceBusinessLayer(this IServiceCollection service)
        {
            service.AddTransient<IOCRManager, OCRManager>();
            service.AddTransient<ISaveFileManager, SaveFileManager>();
            return service;
        }

    }
}
