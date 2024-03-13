using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class SLL_Node
    {
        int value;
        internal SLL_Node next;

        public SLL_Node(int data)
        {
            value = data;
            next = null;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int _value)
        {
            this.value = _value;
        }

    }
}
