using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveField_Refactoring
{
    public class AccountType { }

    public class Account_Before
    {
        private AccountType _type = new AccountType();

        // Lãi suất (InterestRate) đang nằm ở Account, nhưng thực tế nó phụ thuộc vào AccountType
        private double _interestRate = 0.05;

        public double InterestForAmount(double amount, int days)
        {
            return _interestRate * amount * days / 365;
        }
    }
}
