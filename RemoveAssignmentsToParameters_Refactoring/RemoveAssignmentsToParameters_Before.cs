using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAssignmentsToParameters_Refactoring
{
    public class Discount_Before
    {
        // Tham số inputVal bị thay đổi (gán lại) ngay trong hàm
        public int Calculate(int inputVal, int quantity)
        {
            if (inputVal > 50)
            {
                inputVal -= 2;
            }
            if (quantity > 100)
            {
                inputVal -= 1;
            }
            return inputVal;
        }
    }

}
