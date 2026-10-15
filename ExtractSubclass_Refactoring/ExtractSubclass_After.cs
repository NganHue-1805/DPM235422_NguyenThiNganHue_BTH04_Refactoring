using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubclass_Refactoring
{
    // Lớp cha (Chỉ chứa thuộc tính chung)
    public class JobItem_After
    {
        public int TotalPrice { get; set; }
        public int UnitPrice { get; set; }

        public JobItem_After(int unitPrice, int quantity)
        {
            UnitPrice = unitPrice;
            TotalPrice = unitPrice * quantity;
        }
    }

    // Lớp con (Kế thừa và chứa thuộc tính riêng)
    public class LaborItem : JobItem_After
    {
        public string EmployeeName { get; set; }

        public LaborItem(int unitPrice, int quantity, string empName) : base(unitPrice, quantity)
        {
            EmployeeName = empName;
        }
    }
}
