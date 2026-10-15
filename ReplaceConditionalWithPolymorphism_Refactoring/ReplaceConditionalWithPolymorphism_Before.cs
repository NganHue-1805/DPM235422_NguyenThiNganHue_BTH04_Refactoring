using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceConditionalWithPolymorphism_Refactoring
{
    public class Bird_Before
    {
        public string Type { get; set; }

        public double GetSpeed()
        {
            // Dùng switch kiểm tra loại chim
            switch (Type)
            {
                case "European": return 25.0;
                case "African": return 30.0;
                case "Norwegian": return 15.0;
                default: return 0;
            }
        }
    }
}
