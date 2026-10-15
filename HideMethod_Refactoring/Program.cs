using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HIDE METHOD REFACTORING ===\n");

            var after = new Employee_After();
            Console.WriteLine($"Lương (After): {after.CalculateSalary()}");
            // after.Bonus(); // Lỗi: Không thể truy cập vì đã private

            Console.WriteLine();
            var real = new DonHang_Real();
            real.InTongTien();

            Console.ReadLine();
        }
    }
}
