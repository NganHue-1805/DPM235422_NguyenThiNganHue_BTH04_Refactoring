using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE SUBCLASS WITH FIELDS ===\n");

            var male = Person_After.CreateMale();
            Console.WriteLine($"Mã giới tính (After): {male.GetCode()}");

            Console.WriteLine();
            var goiVip = GoiCuoc_Real.Premium();
            goiVip.HienThi();

            Console.ReadLine();
        }
    }
}
