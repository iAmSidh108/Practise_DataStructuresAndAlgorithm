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

        public void Push(int Value)
        {

        }

        public void Pop()
        {

        }

        public void Peek()
        {

        }

        public int StackTop()
        {
            return array[top];
        }

        public int StackBottom()
        {
            return array[0];
        }
    }
}
