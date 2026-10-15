using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceInheritanceWithDelegation_Refactoring
{
    // MyStack kế thừa từ List là sai lầm vì nó sẽ bị lộ các hàm như Insert, RemoveAt...
    // Stack chỉ nên có Push và Pop
    public class MyStack_Before : List<object>
    {
        public void Push(object item)
        {
            this.Add(item);
        }

        public object Pop()
        {
            var item = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
            return item;
        }
    }
}
