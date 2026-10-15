using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod_Refactoring
{
    public class AccountType
    {
        public bool IsPremium { get; set; }
    }

    public class Account_Before
    {
        private AccountType _type = new AccountType { IsPremium = true };
        private int _daysOverdrawn = 10;

        // Hàm này tính phí thấu chi nhưng lại phụ thuộc quá nhiều vào AccountType
        public double OverdraftCharge()
        {
            if (_type.IsPremium)
            {
                int result = 10;
                if (_daysOverdrawn > 7)
                    result += (_daysOverdrawn - 7) * 2;
                return result;
            }
            return _daysOverdrawn * 1.5;
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
                result += OverdraftCharge();
            return result;
        }
    }
}
