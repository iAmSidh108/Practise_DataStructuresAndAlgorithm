using Queue_Linked;

LinkedQueue linkedQueue = new LinkedQueue();

Console.WriteLine(linkedQueue.IsEmpty());
Console.WriteLine(linkedQueue.IsFull());

linkedQueue.Enqueue(5);
linkedQueue.Enqueue(13);
linkedQueue.Enqueue(7);
linkedQueue.Enqueue(9);
linkedQueue.Enqueue(1);
linkedQueue.Enqueue(4);

linkedQueue.PeekFront();
linkedQueue.PeekRear();

linkedQueue.Traverse();

linkedQueue.Dequeue();
linkedQueue.Dequeue();
linkedQueue.Dequeue();

linkedQueue.Traverse();

linkedQueue.PeekFront();
linkedQueue.PeekRear();
