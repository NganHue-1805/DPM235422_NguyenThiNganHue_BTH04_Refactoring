using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithStateStrategy_Refactoring
{
    public class Employee_Before
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public int Type { get; set; }

        public Employee_Before(int type) { Type = type; }

        public int PayAmount()
        {
            switch (Type)
            {
                case ENGINEER: return 1000;
                case SALESMAN: return 500;
                default: return 0;
            }
        }
    }
}
