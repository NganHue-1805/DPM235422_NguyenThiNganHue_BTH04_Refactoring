using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== MOVE METHOD REFACTORING ===\n");

            var after = new Account_After();
            Console.WriteLine("Phí ngân hàng (After): " + after.BankCharge());

            Console.WriteLine();
            var real = new NhanVien_Real();
            real.InLuong();

            Console.ReadLine();
        }
    }
}
