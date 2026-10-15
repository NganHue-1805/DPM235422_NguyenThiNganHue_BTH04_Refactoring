using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownField_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PUSH DOWN FIELD REFACTORING ===\n");

            var after = new Salesman_After();
            after.PrintQuota();

            Console.WriteLine();
            var real = new XeDien();
            real.HienThi();

            Console.ReadLine();
        }
    }
}
