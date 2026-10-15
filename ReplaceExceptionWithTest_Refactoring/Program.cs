using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceExceptionWithTest_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE EXCEPTION WITH TEST ===\n");

            var after = new ResourcePool_After();
            Console.WriteLine($"Tài nguyên tại index 5 (After): {after.GetResource(5)}");

            Console.WriteLine();
            var real = new TaiKhoan_Real();
            real.RutTien(150000); // Thất bại vì dùng if chặn trước

            Console.ReadLine();
        }
    }
}
