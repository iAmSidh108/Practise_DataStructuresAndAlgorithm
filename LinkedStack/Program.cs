using StackUsingLinkedList.LinkedStack;

LinkedStack stack = new LinkedStack();

//Console.WriteLine("Stack is empty: "+ stack.IsEmpty());
//stack.Traverse();
//stack.Clear();

stack.Push(5);
stack.Push(10);
stack.Push(7);
stack.Push(11);

stack.Traverse();
stack.Peek();

stack.Pop();
stack.Traverse();
stack.Peek();

stack.StackTop();
stack.StackBottom();