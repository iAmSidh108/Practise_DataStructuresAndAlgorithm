namespace DoubleLinkedList.BasicOperations
{
    public  class BasicOperations
    {
        public DLL_Node CreateSLL(int data)
        {
            DLL_Node test = new DLL_Node(data);

            return test;
        }

        public void TraverseNodesForward(DLL_Node head)
        {
            if (head.next == null) return;

            Console.WriteLine("\n Traversing Forward...........");

            while (head != null)
            {

                Console.Write(" " + head.GetValue());
                head = head.next;
            }
        }

        public void TraverseNodesBackward(DLL_Node lastNode)
        {
            if (lastNode.prev == null) return;

            Console.WriteLine("Traversing Backward...........");

            while (lastNode != null)
            {

                Console.Write(" " + lastNode.GetValue());
                lastNode = lastNode.prev;
            }
        }


        //Rest all operations are same as Single Linked List, So I wll do it only for backward iterations
        #region Insertion
        public DLL_Node InsertAtFront(DLL_Node last, int data)
        {

            DLL_Node test = CreateSLL(data);
            test.prev = last;
            //head= test;

            Console.WriteLine($"\n Inserted {data} at the first index");
            TraverseNodesBackward(test);
            return test;

        }

        public DLL_Node InsertAtEnd(DLL_Node last, int data)
        {

            DLL_Node newNode = CreateSLL(data);

            if (last == null)
            {
                // If the linked list is empty, the new node becomes the head
                last = newNode;
            }
            else
            {
                DLL_Node current = last;

                // Traverse to the end of the linked list
                while (current.prev != null)
                {
                    current = current.prev;
                }

                // Insert the new node at the end
                current.prev = newNode;
            }

            Console.WriteLine($"\n The {data} is added at the end of LinkedList.");
            TraverseNodesBackward(last);
            return last;
        }

        public DLL_Node InsertAtAnIndex(DLL_Node last, int data, int index)
        {
            DLL_Node newNode = CreateSLL(data);
                
            if (last == null)
            {
                // If the linked list is empty, the new node becomes the head
                last = newNode;
            }
            else
            {
                DLL_Node current = last;
                int i = 0;

                // Traverse to the end of the linked list
                while (i != index - 1 && current != null)
                {
                    current = current.prev;
                    i++;
                }

                // Insert the new node at the end
                newNode.prev = current.prev;
                current.prev = newNode;
            }
            Console.WriteLine($"\n The {data} is added at the {index} index of LinkedList.");
            TraverseNodesBackward(last);
            return last;
        }

        public DLL_Node InsertAfterNode(DLL_Node previousNode, DLL_Node last, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("LinkedList is empty.");
            }
            else
            {
                DLL_Node newNode = CreateSLL(data);

                newNode.prev = previousNode.prev;
                previousNode.prev = newNode;

                Console.WriteLine($"\n The {data} is added after the given previous index of LinkedList.");
                TraverseNodesBackward(last);
            }
            return last;
        }

        #endregion

        #region Deletion
        public DLL_Node DeleteFirstNode(DLL_Node last)
        {
            if (last == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else
            {
                last = last.prev;
            }
            Console.WriteLine("\n Deleted First node.");
            TraverseNodesBackward(last);


            return last;
        }

        public DLL_Node DeleteLastNode(DLL_Node last)
        {
            if (last == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else if (last.prev == null)
            {
                last = null;
            }
            else
            {
                DLL_Node current = last;
                while (current.prev.prev != null)
                {
                    current = current.prev;
                }

                current.prev = null;
            }

            Console.WriteLine("\n Deleted Last node.");
            TraverseNodesBackward(last);

            return last;
        }

        public DLL_Node DeleteAtAnIndex(DLL_Node last, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Enter a valid index greater than 0.");


            }
            else if (index == 0)
            {
                last = last.prev;

            }
            else
            {
                DLL_Node tempPointer = last;
                for (int i = 0; i < index - 1 && tempPointer != null; i++)
                {
                    tempPointer = tempPointer.prev;
                }

                tempPointer.prev = tempPointer.prev.prev;

            }
            Console.WriteLine($"\n Deleted node at {index} index.");
            TraverseNodesBackward (last);

            return last;
        }

        public DLL_Node DeleteNodeWithValue(DLL_Node last, int value)
        {
            if (last == null)
            {
                Console.WriteLine("The linkedList is empty");
            }
            else if (last.prev == null)
            {
                last = null;
            }
            else
            {
                DLL_Node p = last;
                DLL_Node q = last.prev;

                while (q.GetValue() != value && q.prev != null)
                {
                    p = p.prev;
                    q = q.prev;
                }

                if (q.GetValue() == value)
                {
                    p.prev = q.prev;
                    Console.WriteLine($"\n The value {value} has been removed from the list.");
                    TraverseNodesBackward(last);

                }
                else
                {
                    Console.WriteLine($"\n The value {value} doesn't exist.");
                }

            }
            return last;

        }

        #endregion

        public DLL_Node ReverseTheLinkedList(DLL_Node last)
        {
            DLL_Node prevNode = null;
            DLL_Node current = last;
            DLL_Node temp = null;

            while (current != null)
            {
                temp = current.prev;
                current.prev = prevNode;
                prevNode = current;
                current = temp;
            }

            last = prevNode;

            Console.WriteLine("\n Congrats, the linkedList has been reversed.");
            TraverseNodesBackward(last);
            return last;


        }

        public bool Search(DLL_Node last, int value)
        {
            DLL_Node current = last;
            while (current != null)
            {
                if (current.GetValue() == value)
                {
                    Console.WriteLine($"\n Element {value} Found");
                    return true;

                }

                current = current.prev;
            }

            Console.WriteLine($"\n Element {value} not Found");
            return false;


        }

        public DLL_Node SortAscending(DLL_Node last)
        {
            List<int> tempList = new List<int>();

            DLL_Node temp = last;
            while (temp != null)
            {
                tempList.Add(temp.GetValue());
                temp = temp.prev;
            }

            tempList.Sort();

            int i = 0;
            temp = last;

            while (temp != null)
            {
                temp.SetValue(tempList[i]);
                i++;
                temp = temp.prev;
            }

            Console.WriteLine("\n Congrats, the linkedList has been sorted in ascending order.");
            TraverseNodesBackward(last);
            return last;


        }

    }
}
