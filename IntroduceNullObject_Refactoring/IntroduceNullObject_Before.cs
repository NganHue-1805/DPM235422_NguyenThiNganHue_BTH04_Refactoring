using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceNullObject_Refactoring
{
    public class Customer_Before
    {
        public string GetPlan() => "Premium Plan";
    }

    public class IntroduceNullObject_Before
    {
        public void PrintPlan(Customer_Before customer)
        {
            string plan;
            // Phải check null thủ công
            if (customer == null)
            {
                plan = "Basic Plan";
            }
            else
            {
                plan = customer.GetPlan();
            }
            Console.WriteLine("Plan (Before): " + plan);
        }
    }
}
