using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDelegationWithInheritance_Refactoring
{
    public class Person_After
    {
        public string GetName() => "Alice";
        public int GetAge() => 30;
    }

    // Đổi sang Kế thừa: Tự động có sẵn GetName() và GetAge() mà không cần viết lại
    public class Employee_After : Person_After
    {
        public string GetDepartment() => "IT";
    }
}
