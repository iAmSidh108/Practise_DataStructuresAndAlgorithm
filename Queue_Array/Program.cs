using Queue_Array;

Queue queue = new Queue(5);

queue.Traverse();

Console.WriteLine(queue.IsFull());
Console.WriteLine(queue.IsEmpty());

//Here the queue is empty
queue.Dequeue();

//Here we will add 5 elements,So that we would trigger FullQueue
//(Size of Queue is 5 but we can only add 4 elements because 1 index is reserved for circular queue pointer)
queue.Enqueue(5);
queue.Enqueue(9);
queue.Enqueue(1);

queue.Dequeue();
queue.Dequeue();

queue.Enqueue(12);
queue.Enqueue(21);
queue.Enqueue(3);

queue.Traverse();

queue.PeekFront();
queue.PeekRear();

Console.WriteLine(queue.IsFull());
Console.WriteLine(queue.IsEmpty());

//Here we will try to dequeue more than elements.
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(3);


Console.WriteLine(queue.IsFull());
Console.WriteLine(queue.IsEmpty());
