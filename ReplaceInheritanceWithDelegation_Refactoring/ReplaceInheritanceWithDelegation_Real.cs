using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceInheritanceWithDelegation_Refactoring
{
    // Thực tế: Giỏ hàng không nên kế thừa List<SanPham> vì người ngoài có thể gọi gioHang.Clear() bừa bãi.
    // Nên nhúng List vào bên trong để quản lý.
    public class GioHang_Real
    {
        private List<string> _danhSachSanPham = new List<string>();

        public void ThemSanPham(string tenSP)
        {
            _danhSachSanPham.Add(tenSP);
            Console.WriteLine($"[Thực tế] Đã thêm '{tenSP}' vào giỏ.");
        }

        public int DemSoLuong()
        {
            return _danhSachSanPham.Count;
        }
    }
}
