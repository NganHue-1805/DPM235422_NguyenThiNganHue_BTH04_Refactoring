using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod_Refactoring
{
    public class Customer_Before { }

    public class RegularCustomer_Before : Customer_Before
    {
        // Hàm này bị viết lặp lại
        public void CreateBill(double amount)
        {
            Console.WriteLine($"Tạo hóa đơn: {amount}");
        }
    }

    public class PremiumCustomer_Before : Customer_Before
    {
        // Hàm này y hệt ở RegularCustomer
        public void CreateBill(double amount)
        {
            Console.WriteLine($"Tạo hóa đơn: {amount}");
        }
    }
}
