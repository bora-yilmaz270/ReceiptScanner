using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptScanner.ScannerClient.Model;

namespace ReceiptScanner.ScannerClient.Abstract
{
    interface IOCRManager:IDisposable
    {
        public List<Root> GetReceiptJsonFromOcrService();
    }
}
