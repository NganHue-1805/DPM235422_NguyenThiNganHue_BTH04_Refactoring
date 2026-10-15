using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownField_Refactoring
{
    // Thực tế: Lớp Xe (Cha) không nên chứa thuộc tính DungLuongPin, vì Xe Đạp không có pin
    public class Xe { }

    public class XeDien : Xe
    {
        // Đẩy DungLuongPin xuống đúng lớp Xe Điện
        public int DungLuongPin { get; set; } = 5000;

        public void HienThi() => Console.WriteLine($"[Thực tế] Xe điện - Pin: {DungLuongPin} mAh");
    }

    public class XeDap : Xe { }
}
