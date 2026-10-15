using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTempWithQuery_Refactoring
{
    public class HoaDon_Real
    {
        private int _soLuongBia = 10;
        private double _giaBia = 20000;
        private double _phiPhucVu = 50000;

        public void InThongTinThanhToan()
        {
            // Thay vì dùng biến tạm tổng hợp ở đây, ta gọi trực tiếp Query tính toán
            Console.WriteLine($"[Thực tế] Tiền bia: {TienBia()} | Tổng phải trả: {TongTien()}");
        }

        private double TienBia() => _soLuongBia * _giaBia;
        private double TongTien() => TienBia() + _phiPhucVu;
    }
}
