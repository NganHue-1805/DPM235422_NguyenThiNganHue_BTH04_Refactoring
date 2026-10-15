using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSuperclass_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== EXTRACT SUPERCLASS REFACTORING ===\n");

            Party_After emp = new Employee_After { Name = "John" };
            Console.WriteLine($"Chi phí nhân viên (After): {emp.GetAnnualCost()}");

            Console.WriteLine();
            PhuongTien oto = new OTo { BienSo = "51F-123.45" };
            oto.BaoDuong();

            Console.ReadLine();
        }
    }
}
