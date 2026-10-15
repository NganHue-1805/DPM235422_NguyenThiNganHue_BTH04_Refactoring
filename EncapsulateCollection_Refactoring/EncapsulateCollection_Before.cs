using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateCollection_Refactoring
{
    public class Person_Before
    {
        // Lộ toàn bộ List ra ngoài, Client có thể tự do gọi .Add(), .Clear()
        public List<string> Courses { get; set; } = new List<string>();
    }
}
