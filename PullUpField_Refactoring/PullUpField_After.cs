using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpField_Refactoring
{
    public class Employee_After
    {
        // Kéo trường _name lên lớp cha
        protected string _name;
    }

    public class Salesman_After : Employee_After
    {
        public Salesman_After() { _name = "Salesman (After)"; }
        public void PrintName() => Console.WriteLine(_name);
    }

    public class Engineer_After : Employee_After
    {
        public Engineer_After() { _name = "Engineer (After)"; }
        public void PrintName() => Console.WriteLine(_name);
    }
}
