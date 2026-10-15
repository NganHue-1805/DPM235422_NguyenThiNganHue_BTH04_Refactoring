using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithStateStrategy_Refactoring
{
    public abstract class HinhThucGiaoHang
    {
        public abstract double TinhPhi();
    }

    public class GiaoTietKiem : HinhThucGiaoHang
    {
        public override double TinhPhi() => 15000;
    }

    public class GiaoHoaToc : HinhThucGiaoHang
    {
        public override double TinhPhi() => 50000;
    }

    public class DonHang_Real
    {
        private HinhThucGiaoHang _hinhThuc;

        public DonHang_Real(HinhThucGiaoHang hinhThuc) { _hinhThuc = hinhThuc; }

        // Khách hàng có thể đổi ý chuyển từ Giao Tiết Kiệm sang Hỏa Tốc
        public void DoiHinhThuc(HinhThucGiaoHang hinhThucMoi) { _hinhThuc = hinhThucMoi; }

        public void InPhiGiaoHang()
        {
            Console.WriteLine($"[Thực tế] Phí ship là: {_hinhThuc.TinhPhi()} VNĐ");
        }
    }
}
