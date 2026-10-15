using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceErrorCodeWithException_Refactoring
{
    public class Account_Before
    {
        private int _balance = 100;

        public int Withdraw(int amount)
        {
            // Trả về -1 để báo lỗi
            if (amount > _balance)
                return -1;

            _balance -= amount;
            return 0; // Trả về 0 là thành công
        }
    }
}
