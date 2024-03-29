﻿namespace LinkedList.BasicOperations
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

        public SLL_Node DeleteLastNode(SLL_Node head)
        {
            if (head == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else if (head.next==null)
            {
                head = null;
            }
            else
            {
                SLL_Node current = head;
                while (current.next.next != null)
                {
                    current = current.next;
                }

                current.next = null;
            }

            Console.WriteLine("\n Deleted Last node.");
            TraverseNodes(head);

            return head;
        }

        public SLL_Node DeleteAtAnIndex(SLL_Node head, int index)
        {
            if(index<0)
            {
                Console.WriteLine("Enter a valid index greater than 0.");
                

            }
            else if (index == 0)
            {
                head = head.next;
                
            }
            else
            {
                SLL_Node tempPointer = head;
                for(int i=0; i<index-1 && tempPointer!=null; i++)
                {
                    tempPointer = tempPointer.next;
                }

                tempPointer.next = tempPointer.next.next;

            }
            Console.WriteLine($"\n Deleted node at {index} index.");
            TraverseNodes(head);

            return head;
        }

        public SLL_Node DeleteNodeWithValue(SLL_Node head, int value)
        {
            if (head == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                SLL_Node p = head;
                SLL_Node q = head.next;

                while(q.GetValue() != value && q.next != null)
                {
                    p = p.next;
                    q = q.next;
                }

                if (q.GetValue() == value)
                {
                    p.next = q.next;
                    Console.WriteLine($"\n The value {value} has been removed from the list.");

                }
                else
                {
                    Console.WriteLine($"\n The value {value} doesn't exist.");
                }
                
            }
            return head;

        }

        #endregion

        public SLL_Node ReverseTheLinkedList(SLL_Node head)
        {
            SLL_Node prev = null;
            SLL_Node current = head;
            SLL_Node temp = null;

            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            head = prev;

            Console.WriteLine("\n Congrats, the linkedList has been reversed.");
            TraverseNodes(head);
            return head;


        }

        public bool Search(SLL_Node head, int value)
        {
            SLL_Node current = head;
            while (current != null)
            {
                if(current.GetValue() == value)
                {
                    Console.WriteLine($"\n Element {value} Found");
                    return true;

                }

                current=current.next;
            }

            Console.WriteLine($"\n Element {value} not Found");
            return false;

            
        }

        public SLL_Node SortAscending(SLL_Node head)
        {
            List<int> tempList=new List<int>();

            SLL_Node temp = head;
            while (temp != null)
            {
                tempList.Add(temp.GetValue());
                temp = temp.next;
            }

            tempList.Sort();

            int i = 0; 
            temp = head;

            while (temp != null)
            {
                temp.SetValue(tempList[i]);
                i++;
                temp = temp.next;
            }

            Console.WriteLine("\n Congrats, the linkedList has been sorted in ascending order.");
            TraverseNodes(head);
            return head;

            
        }

    }
}
