using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteAlgorithm_Refactoring
{
    public class PersonFinder_Before
    {
        public string FoundPerson(string[] people)
        {
            // Thuật toán cũ: lặp for và if rườm rà
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don") return "Don";
                if (people[i] == "John") return "John";
                if (people[i] == "Kent") return "Kent";
            }
            return "";
        }
    }
}
