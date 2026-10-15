using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithSubclasses_Refactoring
{
    public class Employee_Before
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public int Type { get; set; }

        public Employee_Before(int type) { Type = type; }

        // Switch case dài dòng dựa trên Type Code
        public void DoWork()
        {
            switch (Type)
            {
                case ENGINEER: Console.WriteLine("Kỹ sư đang code."); break;
                case SALESMAN: Console.WriteLine("Sale đang bán hàng."); break;
            }
        }
    }
}
