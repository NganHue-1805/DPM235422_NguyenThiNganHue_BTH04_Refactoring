using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizeMethod_Refactoring
{
    public class Tivi_Real
    {
        // Thay vì viết ChuyenKenh1(), ChuyenKenh2(), ChuyenKenh3()...
        public void ChuyenKenh(int soKenh)
        {
            Console.WriteLine($"[Thực tế] Tivi đang chuyển sang kênh số {soKenh}");
        }
    }
}
