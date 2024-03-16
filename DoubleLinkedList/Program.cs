using DoubleLinkedList.BasicOperations;

BasicOperations test = new BasicOperations();

//Creation of nodes
DLL_Node head = test.CreateSLL(4);
DLL_Node second = test.CreateSLL(8);
DLL_Node third = test.CreateSLL(10);
DLL_Node fourth = test.CreateSLL(3);

//Linking the nodes forward
head.next = second;
second.next = third;
third.next = fourth;
fourth.next = null;

//Linking the nodes backward
fourth.prev = third;
third.prev = second;
second.prev = head;
head.prev = null;

test.TraverseNodesForward(head);
test.TraverseNodesBackward(fourth);
