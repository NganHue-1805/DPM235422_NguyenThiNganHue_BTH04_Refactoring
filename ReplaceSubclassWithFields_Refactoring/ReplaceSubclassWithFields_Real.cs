using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields_Refactoring
{
    public class GoiCuoc_Real
    {
        public double PhiDichVu { get; private set; }

        // Thực tế: Thay vì tạo class GoiVip, GoiThuong. Chỉ cần cấu hình qua thuộc tính
        private GoiCuoc_Real(double phiDichVu)
        {
            PhiDichVu = phiDichVu;
        }

        public static GoiCuoc_Real Basic() => new GoiCuoc_Real(50000);
        public static GoiCuoc_Real Premium() => new GoiCuoc_Real(200000);

        public void HienThi() => Console.WriteLine($"[Thực tế] Phí duy trì gói cước: {PhiDichVu} VNĐ/tháng");
    }
}
