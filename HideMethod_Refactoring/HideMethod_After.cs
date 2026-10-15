using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideMethod_Refactoring
{
    public class Employee_After
    {
        public double CalculateSalary()
        {
            return BaseSalary() + Bonus();
        }

        // Đã đổi sang private
        private double BaseSalary() => 1000;
        private double Bonus() => 200;
    }
}
