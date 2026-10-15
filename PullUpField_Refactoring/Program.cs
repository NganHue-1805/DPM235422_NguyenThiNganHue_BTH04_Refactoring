using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpField_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PULL UP FIELD REFACTORING ===\n");

            var after = new Salesman_After();
            after.PrintName();

            Console.WriteLine();
            var nvReal = new NhanVienFullTime("DPM235422");
            nvReal.HienThi();

            Console.ReadLine();
        }
    }
}
