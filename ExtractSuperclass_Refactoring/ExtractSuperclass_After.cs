using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSuperclass_Refactoring
{
    // Tạo Lớp cha chung
    public abstract class Party_After
    {
        public string Name { get; set; }
        public virtual int GetAnnualCost() => 0;
    }

    public class Department_After : Party_After
    {
        private int _totalCost = 5000;
        public override int GetAnnualCost() => _totalCost;
    }

    public class Employee_After : Party_After
    {
        private int _annualCost = 1000;
        public override int GetAnnualCost() => _annualCost;
    }
}
