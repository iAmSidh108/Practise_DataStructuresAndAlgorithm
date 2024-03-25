using Queue_Array;

Queue queue = new Queue(5);

queue.Traverse();

Console.WriteLine(queue.IsFull());
Console.WriteLine(queue.IsEmpty());

//Here the queue is empty
queue.Dequeue();

//Here we will add 6 elements(So that we would trigger FullQueue)
queue.Enqueue(5);
queue.Enqueue(9);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(15);
queue.Enqueue(20);

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
queue.Dequeue();
queue.Dequeue();

Console.WriteLine(queue.IsFull());
Console.WriteLine(queue.IsEmpty());
