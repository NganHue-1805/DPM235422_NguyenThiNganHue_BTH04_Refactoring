using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizeMethod_Refactoring
{
    public class Employee_Before
    {
        private double _salary = 1000;

        // Viết 2 hàm dư thừa chỉ vì khác nhau con số
        public void TenPercentRaise()
        {
            _salary *= 1.1;
        }

        public void FivePercentRaise()
        {
            _salary *= 1.05;
        }
    }
}
