using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class BasicOperations
    {
        public SLL_Node CreateSLL(int data)
        {
            SLL_Node test= new SLL_Node(data);
            
            return test;
        }

        public void TraverseNodes(SLL_Node head)
        {
            if (head.next == null) return;

            while (head != null)
            {
                Console.WriteLine(head.GetValue());
                head = head.next;
            }
        }
    }
}
