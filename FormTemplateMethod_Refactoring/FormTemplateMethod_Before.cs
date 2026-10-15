using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTemplateMethod_Refactoring
{
    public class HtmlReport_Before
    {
        public void GenerateReport()
        {
            Console.WriteLine("<html><body>"); // Bắt đầu
            Console.WriteLine("<h1>Data</h1>");  // Nội dung
            Console.WriteLine("</body></html>"); // Kết thúc
        }
    }

    public class TextReport_Before
    {
        public void GenerateReport()
        {
            Console.WriteLine("--- REPORT ---"); // Bắt đầu
            Console.WriteLine("Data");           // Nội dung
            Console.WriteLine("--------------"); // Kết thúc
        }
    }
}
