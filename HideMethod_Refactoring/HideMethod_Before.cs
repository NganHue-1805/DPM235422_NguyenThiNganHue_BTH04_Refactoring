using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideMethod_Refactoring
{
    public class Employee_Before
    {
        public double CalculateSalary()
        {
            return BaseSalary() + Bonus();
        }

        // 2 hàm này chỉ dùng nội bộ, để public là không an toàn
        public double BaseSalary() => 1000;
        public double Bonus() => 200;
    }
}
