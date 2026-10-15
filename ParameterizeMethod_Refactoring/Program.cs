using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizeMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PARAMETERIZE METHOD REFACTORING ===\n");

            var after = new Employee_After();
            after.Raise(0.15); // Tăng 15%

            Console.WriteLine();
            var real = new Tivi_Real();
            real.ChuyenKenh(7);

            Console.ReadLine();
        }
    }
}
