using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithStateStrategy_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE TYPE CODE WITH STATE/STRATEGY ===\n");

            var after = new Employee_After(new EngineerType());
            Console.WriteLine($"Lương Kỹ sư (After): {after.PayAmount()}");
            after.SetType(new SalesmanType()); // Đổi loại
            Console.WriteLine($"Lương sau khi chuyển sang Sale: {after.PayAmount()}");

            Console.WriteLine();
            var real = new DonHang_Real(new GiaoTietKiem());
            real.InPhiGiaoHang();
            real.DoiHinhThuc(new GiaoHoaToc());
            real.InPhiGiaoHang();

            Console.ReadLine();
        }
    }
}
