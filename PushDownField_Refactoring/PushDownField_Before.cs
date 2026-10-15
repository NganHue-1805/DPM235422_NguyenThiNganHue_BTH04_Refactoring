using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownField_Refactoring
{
    public class Employee_Before
    {
        // Thuộc tính Quota (Chỉ tiêu) này chỉ Salesman dùng, Engineer không dùng
        protected double _quota = 1000;
    }

    public class Salesman_Before : Employee_Before
    {
        public void PrintQuota() => Console.WriteLine("Chỉ tiêu: " + _quota);
    }

    public class Engineer_Before : Employee_Before
    {
        // Engineer bị kế thừa một thuộc tính rác _quota không cần thiết
    }
}
