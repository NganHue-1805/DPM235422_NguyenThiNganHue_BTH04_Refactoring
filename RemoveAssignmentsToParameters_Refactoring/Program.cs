using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAssignmentsToParameters_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REMOVE ASSIGNMENTS TO PARAMETERS ===\n");

            var after = new Discount_After();
            Console.WriteLine($"Giảm giá (After): {after.Calculate(60, 150)}");

            Console.WriteLine();
            var real = new TinhDiem_Real();
            real.TinhDiemThuong(100, true);

            Console.ReadLine();
        }
    }
}
