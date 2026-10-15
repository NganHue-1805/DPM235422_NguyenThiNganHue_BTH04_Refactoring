using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataValueWithObject_Refactoring
{
    // Tạo hẳn 1 class Customer để dễ dàng mở rộng về sau
    public class Customer
    {
        public string Name { get; }
        public Customer(string name) { Name = name; }
    }

    public class Order_After
    {
        // Sử dụng Object thay vì String
        public Customer Customer { get; set; }

        public Order_After(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}
