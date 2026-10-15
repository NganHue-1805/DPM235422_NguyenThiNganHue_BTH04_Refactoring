using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpConstructorBody_Refactoring
{
    public class Employee_Before
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Manager_Before : Employee_Before
    {
        public int Grade { get; set; }

        public Manager_Before(string name, string id, int grade)
        {
            // Code gán Name và Id bị lặp lại ở mọi class con
            Name = name;
            Id = id;
            Grade = grade;
        }
    }
}
