using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataValueWithObject_Refactoring
{
    public class Order_Before
    {
        // Ban đầu Customer chỉ là 1 chuỗi String
        public string Customer { get; set; }

        public Order_Before(string customerName)
        {
            Customer = customerName;
        }
    }
}
