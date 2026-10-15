using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpConstructorBody_Refactoring
{
    // Lớp cha xử lý các thuộc tính cốt lõi
    public abstract class SanPham
    {
        public string MaSP { get; protected set; }
        public double GiaBan { get; protected set; }

        protected SanPham(string ma, double gia)
        {
            MaSP = ma;
            GiaBan = gia;
        }
    }

    // Thực tế: Lớp con Điện Thoại chỉ cần xử lý thêm những thuộc tính riêng của nó
    public class DienThoai : SanPham
    {
        public string HeDieuHanh { get; private set; }

        public DienThoai(string ma, double gia, string os) : base(ma, gia)
        {
            HeDieuHanh = os;
        }

        public void InThongTin()
        {
            Console.WriteLine($"[Thực tế] Sản phẩm: {MaSP} | Giá: {GiaBan} | OS: {HeDieuHanh}");
        }
    }
}
