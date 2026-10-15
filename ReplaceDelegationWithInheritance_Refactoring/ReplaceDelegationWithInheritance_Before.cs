using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDelegationWithInheritance_Refactoring
{
    public class Person_Before
    {
        public string GetName() => "Alice";
        public int GetAge() => 30;
    }

    public class Employee_Before
    {
        private Person_Before _person = new Person_Before();

        // Viết lại hàm trung gian cho TẤT CẢ các hàm của Person, rất cực và vô nghĩa
        public string GetName() => _person.GetName();
        public int GetAge() => _person.GetAge();

        public string GetDepartment() => "IT";
    }
}
