using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceAssertion_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== INTRODUCE ASSERTION REFACTORING ===\n");

            var after = new Expense_After();
            Console.WriteLine("Giới hạn chi tiêu: " + after.GetExpenseLimit());

            Console.WriteLine();
            var real = new TruongHoc_Real();
            real.SetSiSoLop(45);

            Console.ReadLine();
        }
    }
}
