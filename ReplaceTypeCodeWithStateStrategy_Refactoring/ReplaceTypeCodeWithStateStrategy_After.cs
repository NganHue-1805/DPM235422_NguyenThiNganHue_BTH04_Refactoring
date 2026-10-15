using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithStateStrategy_Refactoring
{
    // Tạo abstract class (Strategy)
    public abstract class EmployeeType
    {
        public abstract int PayAmount();
    }

    public class EngineerType : EmployeeType
    {
        public override int PayAmount() => 1000;
    }

    public class SalesmanType : EmployeeType
    {
        public override int PayAmount() => 500;
    }

    public class Employee_After
    {
        private EmployeeType _type;

        public Employee_After(EmployeeType type) { _type = type; }

        // Có thể thay đổi loại nhân viên bất cứ lúc nào (vd: chuyển từ Sale sang Kỹ sư)
        public void SetType(EmployeeType type) { _type = type; }

        public int PayAmount()
        {
            return _type.PayAmount();
        }
    }
}
