using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDelegationWithInheritance_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE DELEGATION WITH INHERITANCE ===\n");

            var after = new Employee_After();
            Console.WriteLine($"Nhân viên (After): Tên: {after.GetName()}, Tuổi: {after.GetAge()}, Phòng: {after.GetDepartment()}");

            Console.WriteLine();
            var real = new QuanLy_Real();
            real.ChamCong();     // Kế thừa từ lớp cha
            real.DuyetBaoCao();  // Hàm riêng của lớp con

            Console.ReadLine();
        }
    }
}
