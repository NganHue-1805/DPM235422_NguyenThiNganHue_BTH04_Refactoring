using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithExplicitMethods_Refactoring
{
    public class Rectangle_After
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        // Tách thành 2 hàm tường minh, dễ gọi, không bị lỗi gõ sai chữ "height"
        public void SetHeight(int value) => Height = value;
        public void SetWidth(int value) => Width = value;
    }
}
