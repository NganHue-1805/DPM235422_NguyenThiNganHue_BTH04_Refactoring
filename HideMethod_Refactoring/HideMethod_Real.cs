using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideMethod_Refactoring
{
    public class DonHang_Real
    {
        private double _giaGoc = 500000;

        public void InTongTien()
        {
            double tienCuoi = _giaGoc + TinhThueVAT();
            Console.WriteLine($"[Thực tế] Tổng tiền phải trả (đã gồm VAT): {tienCuoi} VNĐ");
        }

        // Client bên ngoài không cần và không nên tự gọi TinhThueVAT(), nên để private
        private double TinhThueVAT()
        {
            return _giaGoc * 0.1;
        }
    }
}
