using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAssignmentsToParameters_Refactoring
{
    public class Discount_After
    {
        public int Calculate(int inputVal, int quantity)
        {
            // Dùng một biến cục bộ thay thế để giữ nguyên vẹn giá trị gốc của tham số
            int result = inputVal;

            if (inputVal > 50) result -= 2;
            if (quantity > 100) result -= 1;

            return result;
        }
    }
}
