using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDownMethod_Refactoring
{
    // Thực tế: Động vật chung không nên có hàm SuaGauGau() vì Mèo không sủa được
    public class DongVat { }

    public class Cho : DongVat
    {
        // Đẩy hành vi Sủa xuống riêng cho loài Chó
        public void SuaGauGau()
        {
            Console.WriteLine("[Thực tế] Gâu gâu gâu!");
        }
    }

    public class Meo : DongVat { }
}
