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

//Insert at the beginning
SLL_Node newHead = test.InsertAtFront(head, 12);
SLL_Node newHead2 = test.InsertAtFront(newHead, 14);
SLL_Node newHead3 = test.InsertAtFront(newHead2, 21);
SLL_Node newHead4 = test.InsertAtFront(newHead3, 36);

//Insert at end
SLL_Node newHead5 = test.InsertAtEnd(newHead4, 50);

//Insert at an index
SLL_Node newHead6 = test.InsertAtAnIndex(newHead5, 70, 3);

//Insert after given node
SLL_Node newHead7 = test.InsertAfterNode(newHead, newHead6, 99);

//Delete at first node
SLL_Node newHead8= test.DeleteFirstNode(newHead7);

//Delete at last node
SLL_Node newHead9 = test.DeleteLastNode(newHead8);

//Delete at an index
SLL_Node newNode10 = test.DeleteAtAnIndex(newHead9, 3);

//Delete node with a value 99(it exists)
SLL_Node newNode11 = test.DeleteNodeWithValue(newNode10, 99);

//Delete node with a value 7(it doesnot exist)
SLL_Node newNode12 = test.DeleteNodeWithValue(newNode11, 7);
test.TraverseNodes(newNode12);

//Reverse the linkedLIst
SLL_Node newNode13 = test.ReverseTheLinkedList(newNode12);

//Search the LinkedLIst for the given value
test.Search(newNode13, 70);
