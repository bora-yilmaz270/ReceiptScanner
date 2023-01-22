using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptScanner.ScannerClient.Abstract;

namespace ReceiptScanner.ScannerClient.Concreate
{
    public class SaveFileManager : ISaveFileManager
    {
        public void SaveTxtFile(string[] text)
        { 
            string fileName = "../../../SavedFiles/response-" + Guid.NewGuid().ToString() + ".txt";
            File.WriteAllLines(fileName, text);
            Console.WriteLine("Text saved as " + fileName);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
