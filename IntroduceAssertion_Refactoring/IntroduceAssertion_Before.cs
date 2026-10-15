using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceAssertion_Refactoring
{
    public class Expense_Before
    {
        private double _expenseLimit = 1000; // Giới hạn chi tiêu

        // Hàm này mặc định giả định limit luôn dương, nếu bị gán số âm sẽ lỗi logic
        public double GetExpenseLimit()
        {
            return _expenseLimit;
        }
    }
}
