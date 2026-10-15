using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMethod_Refactoring
{
    public class PhongBan
    {
        public double HeSoThuong { get; set; } = 1.5;

        // Thực tế: Hàm tính thưởng nên nằm ở Phòng Ban thay vì nằm ở từng Nhân Viên
        public double TinhTienThuong(double luongCoBan)
        {
            return luongCoBan * HeSoThuong;
        }
    }

    public class NhanVien_Real
    {
        public string Ten { get; set; } = "Ngân Huế";
        public double LuongCoBan { get; set; } = 10000000;
        public PhongBan Phong { get; set; } = new PhongBan();

        public void InLuong()
        {
            double thuong = Phong.TinhTienThuong(LuongCoBan);
            Console.WriteLine($"[Thực tế] Nhân viên {Ten} nhận thưởng: {thuong} VNĐ");
        }
    }
}
