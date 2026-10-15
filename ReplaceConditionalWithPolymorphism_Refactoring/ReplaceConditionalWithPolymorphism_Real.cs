using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConditionalWithPolymorphism_Refactoring
{
    public abstract class NhanVien
    {
        public abstract double TinhLuong();
    }

    // Thực tế: Tách riêng logic tính lương cho Dev và Tester, không cần dùng if-else
    public class Developer : NhanVien
    {
        public override double TinhLuong() => 20000000; // Lương cơ bản + Phụ cấp dự án
    }

    public class Tester : NhanVien
    {
        public override double TinhLuong() => 15000000; // Lương cơ bản + Lương OT
    }

    public class ReplaceConditionalWithPolymorphism_Real
    {
        public void XuatLuong(NhanVien nv)
        {
            // Chỉ cần gọi 1 hàm, hệ thống tự biết nó là Dev hay Tester để tính
            Console.WriteLine($"[Thực tế] Lương nhận được: {nv.TinhLuong()}");
        }
    }
}
