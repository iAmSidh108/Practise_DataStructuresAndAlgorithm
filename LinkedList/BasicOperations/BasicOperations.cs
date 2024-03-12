using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        #region Insertion
        public SLL_Node InsertAtFront(SLL_Node head, int data)
        {

            SLL_Node test = CreateSLL(data);
            test.next = head;
            //head= test;

            Console.WriteLine("\n"+ $"Inserted {data} at the first index");
            TraverseNodes(test);
            return test;

        }

        public SLL_Node InsertAtEnd(SLL_Node head, int data)
        {

            SLL_Node newNode = CreateSLL(data);

            if (head == null)
            {
                // If the linked list is empty, the new node becomes the head
                head = newNode;
            }
            else
            {
                SLL_Node current = head;

                // Traverse to the end of the linked list
                while (current.next != null)
                {
                    current = current.next;
                }

                // Insert the new node at the end
                current.next = newNode;
            }
            Console.WriteLine($"\n The {data} is added at the end of LinkedList.");
            TraverseNodes(head);
            return head;
        }

        public SLL_Node InsertAtAnIndex(SLL_Node head, int data, int index)
        {
            SLL_Node newNode = CreateSLL(data);

            if (head == null)
            {
                // If the linked list is empty, the new node becomes the head
                head = newNode;
            }
            else
            {
                SLL_Node current = head;
                int i = 0;

                // Traverse to the end of the linked list
                while (i != index-1 && current != null)
                {
                    current = current.next;
                    i++;
                }

                // Insert the new node at the end
                newNode.next = current.next;
                current.next = newNode;
            }
            Console.WriteLine($"\n The {data} is added at the {index} index of LinkedList.");
            TraverseNodes(head);
            return head;
        }

        public SLL_Node InsertAfterNode(SLL_Node previousNode,SLL_Node head, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("LinkedList is empty.");
            }
            else
            {
                SLL_Node newNode = CreateSLL(data);

                newNode.next = previousNode.next;
                previousNode.next = newNode;

                Console.WriteLine($"\n The {data} is added after the given previous index of LinkedList.");
                TraverseNodes(head);
            }
            return head;
        }

        #endregion

        #region Deletion
        public SLL_Node DeleteFirstNode(SLL_Node head)
        {
            if (head == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else
            {
                head=head.next;
            }
            Console.WriteLine("\n Deleted First node.");
            TraverseNodes(head);
            

            return head;
        }

        



        #endregion

    }
}
