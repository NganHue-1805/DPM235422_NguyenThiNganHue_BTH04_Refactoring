using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteAlgorithm_Refactoring
{
    public class PersonFinder_After
    {
        public string FoundPerson(string[] people)
        {
            // Thuật toán mới: Khai báo List và dùng hàm Contains có sẵn cho gọn
            var candidates = new List<string> { "Don", "John", "Kent" };
            foreach (var p in people)
            {
                if (candidates.Contains(p))
                {
                    return p;
                }
            }
            return "";
        }
    }
}
