using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceErrorCodeWithException_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE ERROR CODE WITH EXCEPTION ===\n");

            var after = new Account_After();
            try { after.Withdraw(500); }
            catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message); }

            Console.WriteLine();
            var real = new PhepChia_Real();
            try { real.ChiaHaiSo(10, 0); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadLine();
        }
    }
}
