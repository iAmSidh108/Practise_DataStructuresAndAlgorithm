using StackUsingArray;

ArrayStack stack = new ArrayStack(10);

bool result = stack.IsEmpty();
Console.WriteLine(result);

result = stack.IsFull();
Console.WriteLine(result);

stack.Push(5);
stack.Push(7);
stack.Push(2);
stack.Push(1);

stack.Pop();

stack.Peek();

stack.ClearStack();

