using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSuperclass_Refactoring
{
    // Thực tế: Lớp cha chung là PhuongTien
    public abstract class PhuongTien
    {
        public string BienSo { get; set; }
        public abstract void BaoDuong();
    }

    public class XeMay : PhuongTien
    {
        public override void BaoDuong()
        {
            Console.WriteLine($"[Thực tế] Xe máy {BienSo} đang thay nhớt.");
        }
    }

    public class OTo : PhuongTien
    {
        public override void BaoDuong()
        {
            Console.WriteLine($"[Thực tế] Ô tô {BienSo} đang thay lọc gió và nhớt.");
        }
    }
}
