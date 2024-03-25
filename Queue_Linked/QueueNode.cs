using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked
{
    public  class QueueNode
    {

        int data;
        internal QueueNode next;

        public QueueNode(int data)
        {
            this.data = data;
            this.next = null;

        }

        public int GetDataValue()
        {
            return data;
        }
    }
}
