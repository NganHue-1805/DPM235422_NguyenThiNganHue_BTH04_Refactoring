using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollapseHierarchy_Refactoring
{
    // Thực tế: Thay vì tạo class con 'HocSinhGioi' kế thừa 'HocSinh' chỉ để thêm thuộc tính 'DiemThuong',
    // ta gộp chung vào lớp 'HocSinh' và kiểm tra bằng một biến cờ (flag).
    public class HocSinh_Real
    {
        public string Ten { get; set; }
        public double DiemTrungBinh { get; set; }
        public double DiemThuong { get; set; }

        public void HienThiThongTin()
        {
            if (DiemTrungBinh >= 8.0)
            {
                DiemThuong = 500000;
                Console.WriteLine($"[Thực tế] HS Giỏi: {Ten} | Thưởng: {DiemThuong} VNĐ");
            }
            else
            {
                Console.WriteLine($"[Thực tế] HS Bình thường: {Ten} | Không có thưởng");
            }
        }
    }
}
