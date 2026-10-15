using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceNullObject_Refactoring
{
    public abstract class Customer
    {
        public abstract string GetPlan();
    }

    public class RealCustomer : Customer
    {
        public override string GetPlan() => "Premium Plan";
    }

    // Tạo Null Object đại diện cho khách hàng rỗng (Khách vãng lai)
    public class NullCustomer : Customer
    {
        public override string GetPlan() => "Basic Plan"; // Mặc định
    }

    public class IntroduceNullObject_After
    {
        public void PrintPlan(Customer customer)
        {
            // Không cần check null nữa, cứ thế gọi
            Console.WriteLine("Plan (After): " + customer.GetPlan());
        }
    }
}
