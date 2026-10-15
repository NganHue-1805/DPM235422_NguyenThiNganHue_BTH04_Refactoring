using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceInheritanceWithDelegation_Refactoring
{
    public class MyStack_After
    {
        // Sử dụng Delegation (Ủy quyền): Khai báo List như một thuộc tính private
        private List<object> _list = new List<object>();

        public void Push(object item)
        {
            _list.Add(item);
        }

        public object Pop()
        {
            var item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return item;
        }
    }
}
