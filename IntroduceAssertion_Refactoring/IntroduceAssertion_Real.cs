using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceAssertion_Refactoring
{
    public class TruongHoc_Real
    {
        // Thực tế: Số lượng học sinh trong lớp không bao giờ được phép âm
        public void SetSiSoLop(int siSo)
        {
            Debug.Assert(siSo >= 0, "Lỗi nghiêm trọng: Sĩ số lớp không thể nhỏ hơn 0!");

            Console.WriteLine($"[Thực tế] Đã cập nhật sĩ số lớp: {siSo} học sinh.");
        }
    }
}
