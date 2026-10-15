using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteAlgorithm_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== SUBSTITUTE ALGORITHM REFACTORING ===\n");

            var after = new PersonFinder_After();
            string[] names = { "Maria", "Kent", "Peter" };
            Console.WriteLine("Tìm thấy (After): " + after.FoundPerson(names));

            Console.WriteLine();
            var real = new KiemTraDanhSach_Real();
            string[] guests = { "Nam", "Lan", "Hương", "Hùng" };
            real.KiemTraKhachVIP(guests);

            Console.ReadLine();
        }
    }
}
