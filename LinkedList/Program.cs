using LinkedList.BasicOperations;

BasicOperations test = new BasicOperations();

//Creation of nodes
SLL_Node head = test.CreateSLL(5);
SLL_Node second = test.CreateSLL(8);
SLL_Node third = test.CreateSLL(10);
SLL_Node fourth = test.CreateSLL(3);

//Linking the nodes
head.next = second;
second.next = third;
third.next = fourth;
fourth.next = null;

//Traversal and Show the value of data of LinkedList
test.TraverseNodes(head);

SLL_Node newHead = test.InsertAtFront(head, 12);
SLL_Node newHead2 = test.InsertAtFront(newHead, 14);
SLL_Node newHead3 = test.InsertAtFront(newHead2, 21);
SLL_Node newHead4 = test.InsertAtFront(newHead3, 36);

