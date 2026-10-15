using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownMethod_Refactoring
{
    public class Employee_After { }

    public class Salesman_After : Employee_After
    {
        // Đẩy phương thức xuống đúng nơi
        public double GetQuota() => 500;
    }

    public class Engineer_After : Employee_After { }
}
