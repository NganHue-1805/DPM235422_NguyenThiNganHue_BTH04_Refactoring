using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractInterface_Refactoring
{
    // Thực tế: Cổng thanh toán yêu cầu mọi thẻ phải có hàm ChargeMoney
    public interface ITheThanhToan
    {
        void TruTien(double amount);
    }

    public class TheCredit : ITheThanhToan
    {
        public void TruTien(double amount) => Console.WriteLine($"[Thực tế] Đã quẹt thẻ Tín dụng {amount} VNĐ (Có phí chuyển đổi).");
    }

    public class TheATM : ITheThanhToan
    {
        public void TruTien(double amount) => Console.WriteLine($"[Thực tế] Đã quẹt thẻ ATM Nội địa {amount} VNĐ (Miễn phí).");
    }

    public class MayPOS
    {
        public void ThanhToan(ITheThanhToan the, double tien)
        {
            the.TruTien(tien);
        }
    }
}
