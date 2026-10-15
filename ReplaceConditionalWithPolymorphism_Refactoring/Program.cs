using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConditionalWithPolymorphism_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE CONDITIONAL WITH POLYMORPHISM ===\n");

            Bird_After bird = new EuropeanBird();
            Console.WriteLine($"Tốc độ chim (After): {bird.GetSpeed()}");

            Console.WriteLine();
            var real = new ReplaceConditionalWithPolymorphism_Real();
            real.XuatLuong(new Developer());
            real.XuatLuong(new Tester());

            Console.ReadLine();
        }
    }
}
