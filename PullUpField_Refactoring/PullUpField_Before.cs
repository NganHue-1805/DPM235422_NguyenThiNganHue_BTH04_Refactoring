using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpField_Refactoring
{
    public class Employee_Before { }

    public class Salesman_Before : Employee_Before
    {
        // Thuộc tính _name bị lặp lại ở cả 2 lớp con
        private string _name = "Salesman";
        public void PrintName() => Console.WriteLine(_name);
    }

    public class Engineer_Before : Employee_Before
    {
        // Thuộc tính _name bị lặp lại
        private string _name = "Engineer";
        public void PrintName() => Console.WriteLine(_name);
    }
}
