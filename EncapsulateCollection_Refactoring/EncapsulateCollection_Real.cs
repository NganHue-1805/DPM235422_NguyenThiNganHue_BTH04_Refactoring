using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateCollection_Refactoring
{
    public class GioHang_Real
    {
        private List<string> _sanPhams = new List<string>();

        public IReadOnlyList<string> DanhSachSanPham => _sanPhams.AsReadOnly();

        public void ThemVaoGio(string sanPham)
        {
            _sanPhams.Add(sanPham);
            Console.WriteLine($"[Thực tế] Đã thêm '{sanPham}' vào giỏ hàng.");
        }

        // Không ai ở ngoài có thể gọi gioHang.DanhSachSanPham.Clear() được nữa
    }
}
