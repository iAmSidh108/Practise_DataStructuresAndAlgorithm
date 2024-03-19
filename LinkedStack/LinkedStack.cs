namespace StackUsingLinkedList.LinkedStack
{
    public class LinkedStack
    {
        StackNode top;

        public void Traverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Can't Traverse because the stack is empty.");
                return;
            }

            else
            {
                while (top != null)
                {
                    Console.Write(top.GetDataValue() + " ");
                }
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public bool IsFull()
        {
            Console.WriteLine("Since we are using LinkedList there cant be limit for Stack. So, it can't be Full.");
            return false;
        }

        public void Clear()
        {
            if (top == null)
                Console.WriteLine("Can't Clear the stack as it is empty already.");
            else
            {
                top = null;
                Console.WriteLine("The Stack has been cleared.");
                Traverse();
            }
        }

        public void Push()
        {

        }

        public void Pop()
        {

        }

        public void Peek()
        {

        }

        public void StackTop()
        {

        }

        public void StackBottom()
        {

        }
    }
}
