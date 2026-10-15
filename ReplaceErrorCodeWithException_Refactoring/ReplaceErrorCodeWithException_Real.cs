using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceErrorCodeWithException_Refactoring
{
    public class PhepChia_Real
    {
        public void ChiaHaiSo(int a, int b)
        {
            if (b == 0)
            {
                // Thực tế: Quăng lỗi thay vì trả về -9999 để đánh lừa
                throw new DivideByZeroException("[Thực tế] Lỗi: Không thể chia cho 0!");
            }
            Console.WriteLine($"[Thực tế] Kết quả {a} / {b} = {a / b}");
        }
    }
}
