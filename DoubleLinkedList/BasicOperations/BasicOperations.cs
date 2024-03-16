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

            Console.WriteLine("\n Traversing Backward...........");

            while (lastNode != null)
            {

                Console.Write(" " + lastNode.GetValue());
                lastNode = lastNode.prev;
            }
        }

        //Rest all operations are same as Single Linked List
    }
}
