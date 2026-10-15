using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceExceptionWithTest_Refactoring
{
    public class TaiKhoan_Real
    {
        private double _soDu = 100000;

        public void RutTien(double soTien)
        {
            // Thực tế: Thay vì cố trừ tiền rồi try-catch bắt lỗi "Thiếu tiền", hãy dùng IF kiểm tra số dư trước
            if (soTien > _soDu)
            {
                Console.WriteLine("[Thực tế] Lỗi: Số dư không đủ để thực hiện giao dịch.");
                return;
            }

            _soDu -= soTien;
            Console.WriteLine($"[Thực tế] Rút thành công {soTien}. Số dư còn lại: {_soDu}");
        }
    }
}
