using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTypeCodeWithSubclasses_Refactoring
{
    public abstract class TheThanhToan
    {
        public abstract void TinhPhiDichVu();
    }

    public class TheNoiDia : TheThanhToan
    {
        public override void TinhPhiDichVu() => Console.WriteLine("[Thực tế] Thẻ Nội Địa: Miễn phí dịch vụ.");
    }

    public class TheQuocTe : TheThanhToan
    {
        public override void TinhPhiDichVu() => Console.WriteLine("[Thực tế] Thẻ Quốc Tế: Phí dịch vụ 2%.");
    }
}
