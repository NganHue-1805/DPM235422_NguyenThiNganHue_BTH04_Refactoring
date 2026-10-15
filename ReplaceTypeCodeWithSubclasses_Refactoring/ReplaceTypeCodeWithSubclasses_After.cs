using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithSubclasses_Refactoring
{
    // Lớp cha trừu tượng
    public abstract class Employee_After
    {
        public abstract void DoWork();
    }

    // Subclass 1
    public class Engineer_After : Employee_After
    {
        public override void DoWork() => Console.WriteLine("Kỹ sư đang code (After).");
    }

    // Subclass 2
    public class Salesman_After : Employee_After
    {
        public override void DoWork() => Console.WriteLine("Sale đang bán hàng (After).");
    }
}
