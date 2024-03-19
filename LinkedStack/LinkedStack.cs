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
                StackNode temp = top;
                while (temp != null)
                {
                    Console.Write(temp.GetDataValue() + " ");
                    temp = temp.next;
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

        public void Push(int value)
        {
            if (IsFull())
                return;

            else
            {
                StackNode nodeToAdd= new StackNode(value);
                nodeToAdd.next= top;
                top=nodeToAdd;
                Console.WriteLine(value +" has been added to the stack.");
            }
        }

        public void Pop()
        {
            if (IsEmpty())
                return;

            else
            {
                int poppedData = top.GetDataValue();
                top = top.next;
                Console.WriteLine("\n "+poppedData+" has been popped.");
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Can't peek as the stack is empty.");
            }
            else
            {
                Console.WriteLine("The value on top is: "+top.GetDataValue());
            }
        }

        public void StackTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No stack Top vakue exists as it is empty.");
            }

            else
                Console.WriteLine("The stackTop value is: " + top.GetDataValue());
        }

        public void StackBottom()
        {

            if (IsEmpty())
            {
                Console.WriteLine("No stack Top vakue exists as it is empty.");
                return;
            }
            else
            {
                StackNode temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine("The stackBottomValue is: " + temp.GetDataValue());
            }
            
        }
    }
}
