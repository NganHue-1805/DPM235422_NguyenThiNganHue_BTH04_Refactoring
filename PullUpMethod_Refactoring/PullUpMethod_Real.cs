using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod_Refactoring
{
    // Thực tế: Lớp cha chung xử lý việc In Thông Tin Liên Hệ
    public abstract class DoiTac
    {
        public string Email { get; set; }

        // Phương thức chung kéo lên lớp cha
        public void InThongTinLienHe()
        {
            Console.WriteLine($"[Thực tế] Liên hệ qua Email: {Email}");
        }
    }

    public class NhaCungCap : DoiTac { }
    public class KhachHangSi : DoiTac { }
}
