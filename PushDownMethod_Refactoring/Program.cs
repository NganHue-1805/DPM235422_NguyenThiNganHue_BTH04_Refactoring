using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PUSH DOWN METHOD REFACTORING ===\n");

            var after = new Salesman_After();
            Console.WriteLine("Quota (After): " + after.GetQuota());

            Console.WriteLine();
            var real = new Cho();
            real.SuaGauGau();

            Console.ReadLine();
        }
    }
}
