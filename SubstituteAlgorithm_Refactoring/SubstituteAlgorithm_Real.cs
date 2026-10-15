using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteAlgorithm_Refactoring
{
    public class KiemTraDanhSach_Real
    {
        public void KiemTraKhachVIP(string[] danhSachKhach)
        {
            string khachVip = "Hương";

            // Thực tế: Thay vì dùng for lặp kiểm tra, ta dùng luôn cú pháp LINQ của C# (.Contains)
            bool coMat = danhSachKhach.Contains(khachVip);

            if (coMat)
                Console.WriteLine($"[Thực tế] Khách VIP {khachVip} ĐÃ có mặt!");
            else
                Console.WriteLine($"[Thực tế] Khách VIP {khachVip} CHƯA có mặt.");
        }
    }
}
