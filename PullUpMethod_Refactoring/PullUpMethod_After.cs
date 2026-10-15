using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod_Refactoring
{
    public class Customer_After
    {
        // Kéo phương thức dùng chung lên lớp cha
        public void CreateBill(double amount)
        {
            Console.WriteLine($"Tạo hóa đơn (After): {amount}");
        }
    }

    public class RegularCustomer_After : Customer_After { }

    public class PremiumCustomer_After : Customer_After { }
}
