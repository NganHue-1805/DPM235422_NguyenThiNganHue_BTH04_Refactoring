using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDelegationWithInheritance_Refactoring
{
    // Lớp cha
    public class NhanVienCoBan
    {
        public void ChamCong() => Console.WriteLine("[Thực tế] Chấm công lúc 8:00 AM.");
    }

    // Thực tế: Quản lý bản chất vẫn là một Nhân Viên, nên Kế thừa là hợp lý nhất.
    public class QuanLy_Real : NhanVienCoBan
    {
        public void DuyetBaoCao() => Console.WriteLine("[Thực tế] Quản lý đang duyệt báo cáo.");
    }
}
