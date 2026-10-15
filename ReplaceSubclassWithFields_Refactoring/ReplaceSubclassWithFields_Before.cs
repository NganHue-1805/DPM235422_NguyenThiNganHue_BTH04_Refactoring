using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubclassWithFields_Refactoring
{
    public abstract class Person_Before
    {
        public abstract char GetCode();
    }

    // 2 Subclass dư thừa chỉ để trả về 1 ký tự
    public class Male_Before : Person_Before
    {
        public override char GetCode() => 'M';
    }

    public class Female_Before : Person_Before
    {
        public override char GetCode() => 'F';
    }
}
