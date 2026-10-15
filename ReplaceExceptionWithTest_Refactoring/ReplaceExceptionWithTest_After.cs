using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceExceptionWithTest_Refactoring
{
    public class ResourcePool_After
    {
        private int[] _resources = { 10, 20, 30 };

        public int GetResource(int index)
        {
            // Kiểm tra (Test) trước, code chạy nhanh và an toàn hơn hẳn
            if (index < 0 || index >= _resources.Length)
            {
                return 0;
            }
            return _resources[index];
        }
    }
}
