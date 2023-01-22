using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptScanner.ScannerClient.Abstract
{
     public interface ISaveFileManager: IDisposable
     {
         public void SaveTxtFile(string[] text);
     }
}
