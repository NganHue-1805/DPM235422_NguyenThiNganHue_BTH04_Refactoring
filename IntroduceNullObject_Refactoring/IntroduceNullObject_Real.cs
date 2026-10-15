using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceNullObject_Refactoring
{
    public interface IDiscount
    {
        double ApplyDiscount(double price);
    }

    public class VipDiscount : IDiscount
    {
        public double ApplyDiscount(double price) => price * 0.8; // Giảm 20%
    }

    // Thực tế: Null Object (Không Giảm Giá)
    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double price) => price; // Giữ nguyên giá
    }

    public class HoaDon_Real
    {
        public void TinhTien(double giaGoc, IDiscount khuyenMai)
        {
            // Cứ tính bình thường mà không sợ khuyenMai bị null gây crash
            Console.WriteLine($"[Thực tế] Giá sau khuyến mãi: {khuyenMai.ApplyDiscount(giaGoc)}");
        }
    }
}
