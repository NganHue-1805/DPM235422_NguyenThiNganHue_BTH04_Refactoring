using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateCollection_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ENCAPSULATE COLLECTION REFACTORING ===\n");

            var after = new Person_After();
            after.AddCourse("Toán");
            after.AddCourse("Lý");
            Console.WriteLine($"Số khóa học (After): {after.Courses.Count}");

            Console.WriteLine();
            var real = new GioHang_Real();
            real.ThemVaoGio("Laptop");

            Console.ReadLine();
        }
    }
}
