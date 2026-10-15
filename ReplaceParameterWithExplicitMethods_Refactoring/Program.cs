using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithExplicitMethods_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE PARAMETER WITH EXPLICIT METHODS ===\n");

            var after = new Rectangle_After();
            after.SetHeight(10);
            after.SetWidth(20);
            Console.WriteLine($"HCN (After): {after.Width} x {after.Height}");

            Console.WriteLine();
            var real = new MayLanh_Real();
            real.BatMayLanh();
            real.TatMayLanh();

            Console.ReadLine();
        }
    }
}
