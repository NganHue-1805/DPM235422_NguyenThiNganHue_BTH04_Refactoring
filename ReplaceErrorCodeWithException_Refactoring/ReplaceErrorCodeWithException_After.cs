using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceErrorCodeWithException_Refactoring
{
    public class Account_After
    {
        private int _balance = 100;

        public void Withdraw(int amount)
        {
            // Ném Exception chuẩn xác
            if (amount > _balance)
                throw new InvalidOperationException("Số dư không đủ để rút tiền!");

            _balance -= amount;
            Console.WriteLine("Rút tiền thành công (After).");
        }
    }
}
