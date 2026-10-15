using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithExplicitMethods_Refactoring
{
    public class MayLanh_Real
    {
        // Thay vì viết: DieuKhien(string lenh) { if (lenh == "Bật") ... else if (lenh == "Tắt") ... }
        public void BatMayLanh()
        {
            Console.WriteLine("[Thực tế] Đã BẬT máy lạnh.");
        }

        public void TatMayLanh()
        {
            Console.WriteLine("[Thực tế] Đã TẮT máy lạnh.");
        }
    }
}
