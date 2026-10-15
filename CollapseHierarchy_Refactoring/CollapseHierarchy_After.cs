using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollapseHierarchy_Refactoring
{
    // Gộp luôn thuộc tính của lớp con vào lớp cha và xóa bỏ lớp con
    public class Employee_After
    {
        public string Name { get; set; }
        public double Quota { get; set; } // Gộp từ Salesman lên
    }
}
