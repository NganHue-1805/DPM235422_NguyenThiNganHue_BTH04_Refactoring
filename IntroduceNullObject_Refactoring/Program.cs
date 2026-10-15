using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceNullObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INTRODUCE NULL OBJECT REFACTORING ===\n");

            var after = new IntroduceNullObject_After();
            Customer guest = new NullCustomer(); // Khách chưa đăng nhập
            after.PrintPlan(guest);

            Console.WriteLine();
            var real = new HoaDon_Real();
            real.TinhTien(100000, new NoDiscount()); // Không có mã giảm giá

            Console.ReadLine();
        }
    }
}
