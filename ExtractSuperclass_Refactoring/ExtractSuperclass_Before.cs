using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSuperclass_Refactoring
{
    public class Department_Before
    {
        public string Name { get; set; } // Giống Employee
        public int TotalAnnualCost { get; set; } // Giống Employee
    }

    public class Employee_Before
    {
        public string Name { get; set; } // Giống Department
        public int AnnualCost { get; set; } // Giống Department
    }
}
