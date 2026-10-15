using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollapseHierarchy_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== COLLAPSE HIERARCHY REFACTORING ===\n");

            var after = new Employee_After { Name = "John", Quota = 1000 };
            Console.WriteLine($"Nhân viên (After): {after.Name} - Chỉ tiêu: {after.Quota}");

            Console.WriteLine();
            var real = new HocSinh_Real { Ten = "Ngân Huế", DiemTrungBinh = 9.0 };
            real.HienThiThongTin();

            Console.ReadLine();
        }
    }
}
