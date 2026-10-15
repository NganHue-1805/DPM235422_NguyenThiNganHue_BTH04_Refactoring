using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubclass_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== EXTRACT SUBCLASS REFACTORING ===\n");

            var labor = new LaborItem(50, 5, "John");
            Console.WriteLine($"Công việc của {labor.EmployeeName} (After) - Giá: {labor.TotalPrice}");

            Console.WriteLine();
            var dev = new LapTrinhVien("Ngân Huế", 20000000, "C# .NET");
            dev.HienThi();

            Console.ReadLine();
        }
    }
}
