using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataValueWithObject_Refactoring
{
    // Thực tế: Thay vì dùng string "0987654321" cho Số Điện Thoại, ta dùng Object để lấy được mã vùng
    public class SoDienThoai
    {
        public string MaVung { get; set; }
        public string So { get; set; }

        public SoDienThoai(string ma, string so) { MaVung = ma; So = so; }
        public string HienThi() => $"(+{MaVung}) {So}";
    }

    public class KhachHang_Real
    {
        public string Ten { get; set; }
        public SoDienThoai SDT { get; set; }

        public void HienThiThongTin()
        {
            Console.WriteLine($"[Thực tế] Khách hàng: {Ten} | LH: {SDT.HienThi()}");
        }
    }
}
