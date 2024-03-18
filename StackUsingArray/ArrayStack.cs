namespace StackUsingArray
{
    internal class ArrayStack
    {
        int size;
        int top;
        int[] array;

        public ArrayStack(int size, int top=-1)
        {
            this.size = size;
            this.top = top;
            array= new int[size];
        }

        public void Traverse()
        {
            if (top >= 0)
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack is Empty.");
            }
            
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;

            else
                return false;
        }

        public bool IsFull()
        {
            if (top == array.Length - 1)
                return true;

            else return false;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow: The stack is full.");
            }
            else
            {
                array[++top] = value;
                Console.WriteLine(value + " has been added to the stack");
                Traverse();
            }
            
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow: No element to Pop.");
            }
            else
            {
                top--;
                Console.WriteLine("Top value has been removed from the stack");
                Traverse();
            }
            
        }

        public void Peek()
        {
            if (top < 0)
                Console.WriteLine("Stack is empty.");

            else
            {
                Console.WriteLine("The top element is: "+array[top]);
            }
        }

        public int StackTop()
        {
            return array[top];
        }

        public int StackBottom()
        {
            return array[0];
        }

        public void ClearStack()
        {
            top = -1;
            Console.WriteLine("The stack has been cleared.");
            Traverse();
        }
    }
}
