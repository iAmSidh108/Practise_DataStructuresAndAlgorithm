namespace StackUsingLinkedList.LinkedStack
{
    public class StackNode
    {
        int data;
        StackNode next;

        public StackNode(int data)
        {
            this.data = data;
            this.next = null;

        }

        public int GetDataValue()
        {
            return data;
        }
    }
}
