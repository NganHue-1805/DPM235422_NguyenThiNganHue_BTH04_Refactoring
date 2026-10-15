using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpConstructorBody_Refactoring
{
    public class Employee_After
    {
        public string Name { get; protected set; }
        public string Id { get; protected set; }

        // Đưa phần khởi tạo chung lên lớp cha
        protected Employee_After(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }

    public class Manager_After : Employee_After
    {
        public int Grade { get; private set; }

        // Gọi base(...) để lớp cha tự xử lý Name và Id
        public Manager_After(string name, string id, int grade) : base(name, id)
        {
            Grade = grade;
        }
    }
}
