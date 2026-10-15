using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PULL UP METHOD REFACTORING ===\n");

            var after = new PremiumCustomer_After();
            after.CreateBill(500); // Kế thừa từ Customer_After

            Console.WriteLine();
            var ncc = new NhaCungCap { Email = "contact@ncc.com" };
            ncc.InThongTinLienHe();

            Console.ReadLine();
        }
    }
}
