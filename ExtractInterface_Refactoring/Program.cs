using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractInterface_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== EXTRACT INTERFACE REFACTORING ===\n");

            var timeSheet = new TimeSheet_After();
            var emp = new Employee_After();
            Console.WriteLine("Tính lương (After): " + timeSheet.Charge(emp, 5));

            Console.WriteLine();
            var mayPOS = new MayPOS();
            ITheThanhToan theTinDung = new TheCredit();
            mayPOS.ThanhToan(theTinDung, 250000);

            Console.ReadLine();
        }
    }
}
