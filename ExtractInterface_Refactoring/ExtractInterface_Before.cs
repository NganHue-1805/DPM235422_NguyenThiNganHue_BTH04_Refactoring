using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractInterface_Refactoring
{
    public class Employee_Before
    {
        public int GetRate() => 500;
        public bool HasSpecialSkill() => true;
        public string GetName() => "John";
        public string GetDepartment() => "IT";
    }

    public class TimeSheet_Before
    {
        // Tính tiền công, bị phụ thuộc cứng vào class Employee
        public double Charge(Employee_Before emp, int days)
        {
            int baseCharge = emp.GetRate() * days;
            if (emp.HasSpecialSkill())
                return baseCharge * 1.5;
            return baseCharge;
        }
    }
}
