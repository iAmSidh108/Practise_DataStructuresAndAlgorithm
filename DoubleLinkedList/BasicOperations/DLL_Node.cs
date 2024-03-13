using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList.BasicOperations
{
    public class DLL_Node
    {
        int value;
        internal DLL_Node next;
        internal DLL_Node prev;

        public DLL_Node(int data)
        {
            value = data;
            next = null;
            prev = null;
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
