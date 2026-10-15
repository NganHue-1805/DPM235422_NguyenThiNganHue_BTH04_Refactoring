using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceInheritanceWithDelegation_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE INHERITANCE WITH DELEGATION ===\n");

            var stack = new MyStack_After();
            stack.Push("A");
            stack.Push("B");
            Console.WriteLine("Pop từ Stack (After): " + stack.Pop());

            Console.WriteLine();
            var gioHang = new GioHang_Real();
            gioHang.ThemSanPham("Laptop Dell");
            gioHang.ThemSanPham("Chuột Không Dây");
            Console.WriteLine($"[Thực tế] Trong giỏ có {gioHang.DemSoLuong()} sản phẩm.");

            Console.ReadLine();
        }
    }
}
