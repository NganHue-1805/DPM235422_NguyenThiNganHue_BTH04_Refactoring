using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveField_Refactoring
{
    public class AccountType_After
    {
        // Chuyển trường Lãi suất sang AccountType
        public double InterestRate { get; set; } = 0.05;
    }

    public class Account_After
    {
        private AccountType_After _type = new AccountType_After();

        public double InterestForAmount(double amount, int days)
        {
            // Lấy lãi suất từ AccountType
            return _type.InterestRate * amount * days / 365;
        }
    }
}
