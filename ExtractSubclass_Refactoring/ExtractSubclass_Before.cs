using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubclass_Refactoring
{
    public class JobItem_Before
    {
        public int TotalPrice { get; set; }
        public int UnitPrice { get; set; }
        public bool IsLabor { get; set; }

        // Thuộc tính này Employee mới có, nếu JobItem là Máy móc thì thuộc tính này bị dư thừa
        public string EmployeeName { get; set; }

        public JobItem_Before(int unitPrice, int quantity, bool isLabor, string empName)
        {
            UnitPrice = unitPrice;
            IsLabor = isLabor;
            EmployeeName = empName;
            TotalPrice = unitPrice * quantity;
        }
    }
}
