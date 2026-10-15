using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithSubclasses_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== REPLACE TYPE CODE WITH SUBCLASSES ===\n");

            Employee_After eng = new Engineer_After();
            eng.DoWork(); // Đa hình tự động gọi đúng hàm

            Console.WriteLine();
            TheThanhToan theMasterCard = new TheQuocTe();
            theMasterCard.TinhPhiDichVu();

            Console.ReadLine();
        }
    }
}
