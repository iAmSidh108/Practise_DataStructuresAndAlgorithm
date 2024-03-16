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

test.TraverseNodesBackward(fourth);

//Insertion 
DLL_Node newLast = test.InsertAtFront(fourth, 12);
newLast = test.InsertAtEnd(newLast, 14);
newLast = test.InsertAtAnIndex(newLast, 20, 3);
newLast = test.InsertAfterNode(fourth, newLast, 21);

//Deletion
newLast=test.DeleteFirstNode(newLast);
newLast = test.DeleteLastNode(newLast);
newLast = test.DeleteAtAnIndex(newLast, 2);
newLast = test.DeleteNodeWithValue(newLast,20);

//Reverse
newLast=test.ReverseTheLinkedList(newLast);

//Search
test.Search(newLast, 21);

//Insert and then Sort Ascending
newLast = test.InsertAtEnd(newLast, 99);
newLast = test.InsertAtEnd(newLast, 87);
newLast = test.InsertAtEnd(newLast, 77);
newLast = test.SortAscending(newLast);