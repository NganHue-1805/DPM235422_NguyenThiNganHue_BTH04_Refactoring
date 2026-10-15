using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveField_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== MOVE FIELD REFACTORING ===\n");

            var after = new Account_After();
            Console.WriteLine("Tiền lãi (After): " + after.InterestForAmount(10000, 30));

            Console.WriteLine();
            var real = new DonHang_Real();
            real.TinhTien();

            Console.ReadLine();
        }
    }
}
