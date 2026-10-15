using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTemplateMethod_Refactoring
{
    // Thực tế: Quy trình pha đồ uống chung
    public abstract class DoUong
    {
        public void PhaChe()
        {
            DunSoiNuoc();
            ChoNguyenLieu();
            RotRaLy();
        }

        private void DunSoiNuoc() => Console.WriteLine("1. Đun sôi nước");
        private void RotRaLy() => Console.WriteLine("3. Rót ra ly");

        // Bước này mỗi loại đồ uống sẽ khác nhau
        protected abstract void ChoNguyenLieu();
    }

    public class CaPhe : DoUong
    {
        protected override void ChoNguyenLieu() => Console.WriteLine("2. Cho bột cà phê và đường vào");
    }
}
