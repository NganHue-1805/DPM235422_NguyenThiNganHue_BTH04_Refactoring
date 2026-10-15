using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpConstructorBody_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PULL UP CONSTRUCTOR BODY ===\n");

            var manager = new Manager_After("Alice", "M001", 1);
            Console.WriteLine($"Quản lý (After): {manager.Name} - ID: {manager.Id}");

            Console.WriteLine();
            var dt = new DienThoai("IP15", 25000000, "iOS");
            dt.InThongTin();

            Console.ReadLine();
        }
    }
}
