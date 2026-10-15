using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceAssertion_Refactoring
{
    public class Expense_After
    {
        private double _expenseLimit = 1000;

        public double GetExpenseLimit()
        {
            // Thêm Assert để lập trình viên bắt lỗi ngay lúc Debug nếu limit bị gán số âm
            Debug.Assert(_expenseLimit >= 0, "Giới hạn chi tiêu không được là số âm!");
            return _expenseLimit;
        }
    }
}
