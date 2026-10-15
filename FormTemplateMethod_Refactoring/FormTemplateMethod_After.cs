using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTemplateMethod_Refactoring
{
    // Lớp cha chứa Template Method
    public abstract class Report_After
    {
        // Template Method (Khung xương)
        public void GenerateReport()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        protected abstract void PrintHeader();
        protected abstract void PrintBody();
        protected abstract void PrintFooter();
    }

    public class HtmlReport_After : Report_After
    {
        protected override void PrintHeader() => Console.WriteLine("<html><body>");
        protected override void PrintBody() => Console.WriteLine("<h1>Data</h1>");
        protected override void PrintFooter() => Console.WriteLine("</body></html>");
    }

    public class TextReport_After : Report_After
    {
        protected override void PrintHeader() => Console.WriteLine("--- REPORT ---");
        protected override void PrintBody() => Console.WriteLine("Data");
        protected override void PrintFooter() => Console.WriteLine("--------------");
    }
}
