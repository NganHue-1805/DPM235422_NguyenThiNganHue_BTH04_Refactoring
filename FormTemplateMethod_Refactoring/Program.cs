using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTemplateMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== FORM TEMPLATE METHOD REFACTORING ===\n");

            Report_After html = new HtmlReport_After();
            html.GenerateReport();

            Console.WriteLine("\n[Thực tế] Pha cà phê:");
            DoUong caPhe = new CaPhe();
            caPhe.PhaChe();

            Console.ReadLine();
        }
    }
}
