using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubclass_Refactoring
{
    // Lớp cha
    public class NhanVien
    {
        public string Ten { get; set; }
        public double LuongCoBan { get; set; }

        public NhanVien(string ten, double luong) { Ten = ten; LuongCoBan = luong; }
    }

    // Thực tế: Lập trình viên là lớp con của Nhân Viên, có thêm thuộc tính Ngôn Ngữ Lập Trình
    public class LapTrinhVien : NhanVien
    {
        public string NgonNguLapTrinh { get; set; }

        public LapTrinhVien(string ten, double luong, string ngonNgu) : base(ten, luong)
        {
            NgonNguLapTrinh = ngonNgu;
        }

        public void HienThi()
        {
            Console.WriteLine($"[Thực tế] Dev: {Ten} | Lương: {LuongCoBan} | Ngôn ngữ: {NgonNguLapTrinh}");
        }
    }
}
