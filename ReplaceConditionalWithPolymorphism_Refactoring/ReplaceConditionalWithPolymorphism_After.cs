using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConditionalWithPolymorphism_Refactoring
{
    public abstract class Bird_After
    {
        // Giao việc tính tốc độ cho lớp con tự quyết định (Đa hình)
        public abstract double GetSpeed();
    }

    public class EuropeanBird : Bird_After
    {
        public override double GetSpeed() => 25.0;
    }

    public class AfricanBird : Bird_After
    {
        public override double GetSpeed() => 30.0;
    }
}
