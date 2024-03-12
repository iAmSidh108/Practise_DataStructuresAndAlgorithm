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

            Console.WriteLine("Traversing...........");
            
            while (head != null)
            {
                
                Console.Write(" "+head.GetValue());
                head = head.next;
            }
        }

        public SLL_Node InsertAtFront(SLL_Node head, int data)
        {

            SLL_Node test = CreateSLL(data);
            test.next = head;
            //head= test;

            Console.WriteLine("\n"+ $"Inserted {data} at the first index");
            TraverseNodes(test);
            return test;

        }


    }
}
