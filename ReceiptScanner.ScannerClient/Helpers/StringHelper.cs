using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptScanner.ScannerClient.Model;

namespace ReceiptScanner.ScannerClient.Helpers
{
    public static class StringHelper
    {
        public static string[] AddLineNumber(string[] text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                text[i] = i + "    " + text[i];
            }

            return text;
        }
        public static string[] AddHeader(List<Root> oCRresult)
        {
            string[] content = oCRresult[0].Description.Split("\n");
            
            string[] text = new string[content.Length+1];

            text[0] = "line    text";

            for (int i = 1; i < content.Length; i++)
            {
                if (!String.IsNullOrEmpty(content[i - 1]))
                {
                    text[i] = content[i - 1];
                }
            }

            return text;
        }
    }
}
