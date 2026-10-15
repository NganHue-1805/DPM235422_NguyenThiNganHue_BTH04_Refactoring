using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizeMethod_Refactoring
{
    public class Employee_After
    {
        private double _salary = 1000;

        // Gộp lại thành 1 hàm duy nhất nhận tham số
        public void Raise(double factor)
        {
            _salary *= (1 + factor);
            Console.WriteLine("Lương sau khi tăng (After): " + _salary);
        }
    }
}
