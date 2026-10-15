using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceParameterWithExplicitMethods_Refactoring
{
    public class Rectangle_Before
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        // Dùng tham số 'name' làm công tắc rẽ nhánh
        public void SetValue(string name, int value)
        {
            if (name == "height") Height = value;
            else if (name == "width") Width = value;
        }
    }
}
