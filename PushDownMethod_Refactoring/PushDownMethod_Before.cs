using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownMethod_Refactoring
{
    public class Employee_Before
    {
        // Phương thức lấy chỉ tiêu (Quota) không áp dụng cho mọi loại nhân viên
        public double GetQuota() => 500;
    }

    public class Salesman_Before : Employee_Before { }

    public class Engineer_Before : Employee_Before { }
}
