using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataValueWithObject_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE DATA VALUE WITH OBJECT ===\n");

            var after = new Order_After("Ngân Huế");
            Console.WriteLine("Tên khách đặt hàng (After): " + after.Customer.Name);

            Console.WriteLine();
            var real = new KhachHang_Real
            {
                Ten = "Công Ty ABC",
                SDT = new SoDienThoai("84", "0123456789")
            };
            real.HienThiThongTin();

            Console.ReadLine();
        }
    }
}
