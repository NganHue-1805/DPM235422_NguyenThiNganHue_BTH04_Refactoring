using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAssignmentsToParameters_Refactoring
{
    public class TinhDiem_Real
    {
        // Thực tế: Tính điểm thành viên
        public void TinhDiemThuong(int diemHienTai, bool isVip)
        {
            int diemKetQua = diemHienTai; // Không dùng diemHienTai += ...

            if (isVip)
            {
                diemKetQua += 500;
            }

            Console.WriteLine($"[Thực tế] Điểm gốc: {diemHienTai} -> Điểm sau khi tính: {diemKetQua}");
        }
    }
}
