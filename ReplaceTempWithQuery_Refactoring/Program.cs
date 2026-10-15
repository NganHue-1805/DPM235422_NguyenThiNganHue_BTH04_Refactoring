using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTempWithQuery_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE TEMP WITH QUERY ===\n");

            var after = new Product_After();
            Console.WriteLine($"Giá sản phẩm (After): {after.GetPrice()}");

            Console.WriteLine();
            var real = new HoaDon_Real();
            real.InThongTinThanhToan();

            Console.ReadLine();
        }
    }
}
