using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveField_Refactoring
{
    public class LoaiKhachHang
    {
        // Thực tế: Tỉ lệ giảm giá phụ thuộc vào Loại Khách Hàng (VIP, Normal)
        public double TiLeGiamGia { get; set; } = 0.2; // VIP giảm 20%
    }

    public class DonHang_Real
    {
        public double TongTien { get; set; } = 500000;
        public LoaiKhachHang LoaiKH { get; set; } = new LoaiKhachHang();

        public void TinhTien()
        {
            double tienDuocGiam = TongTien * LoaiKH.TiLeGiamGia;
            Console.WriteLine($"[Thực tế] Khách được giảm {LoaiKH.TiLeGiamGia * 100}% -> Phải trả: {TongTien - tienDuocGiam} VNĐ");
        }
    }
}
