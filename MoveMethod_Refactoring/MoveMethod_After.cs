using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod_Refactoring
{
    public class AccountType_After
    {
        public bool IsPremium { get; set; }

        // Chuyển hàm tính phí thấu chi sang đúng nơi của nó
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                int result = 10;
                if (daysOverdrawn > 7)
                    result += (daysOverdrawn - 7) * 2;
                return result;
            }
            return daysOverdrawn * 1.5;
        }
    }

    public class Account_After
    {
        private AccountType_After _type = new AccountType_After { IsPremium = true };
        private int _daysOverdrawn = 10;

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
                result += _type.OverdraftCharge(_daysOverdrawn); // Gọi qua AccountType
            return result;
        }
    }
}
