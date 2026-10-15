using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownField_Refactoring
{
    public class Employee_After
    {
        // Lớp cha đã sạch sẽ
    }

    public class Salesman_After : Employee_After
    {
        // Đẩy _quota xuống lớp con thực sự cần nó
        private double _quota = 1000;
        public void PrintQuota() => Console.WriteLine("Chỉ tiêu (After): " + _quota);
    }

    public class Engineer_After : Employee_After
    {
        // Sạch sẽ, không dính líu _quota
    }
}
