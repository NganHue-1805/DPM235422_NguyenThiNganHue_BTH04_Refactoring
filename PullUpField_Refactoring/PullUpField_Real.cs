using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpField_Refactoring
{
    // Thực tế: Lớp cha "NhanVien" sẽ chứa MaNhanVien dùng chung cho cả Full-time và Part-time
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
    }

    public class NhanVienFullTime : NhanVien
    {
        public NhanVienFullTime(string maNV) { MaNhanVien = maNV; }
        public void HienThi() => Console.WriteLine($"[Thực tế] NV Full-time mã: {MaNhanVien}");
    }

    public class NhanVienPartTime : NhanVien
    {
        public NhanVienPartTime(string maNV) { MaNhanVien = maNV; }
        public void HienThi() => Console.WriteLine($"[Thực tế] NV Part-time mã: {MaNhanVien}");
    }
}
