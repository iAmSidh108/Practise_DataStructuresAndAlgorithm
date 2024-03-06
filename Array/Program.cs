using Array;

/*int arrayLength = 10; // Define the length of the array
int[] array = new int[arrayLength];
int filledElements = 7; // Example: assume 7 elements are already filled


List<int> list = new List<int>();
// Populate the array with some initial values
for (int i = 0; i < filledElements; i++)
{
    Console.Write($" Enter {filledElements} elements.");
    array[i] = int.Parse(Console.ReadLine()); // Filling the array with values 1, 2, 3, 4, 5
}

ArrayFunctions functions = new ArrayFunctions();

// Display the array before insertion
Console.WriteLine("Array before insertion:");
functions.PrintAllElemntsInAnArray(array);

// Insert an element at the 3rd index (index 2)
int elementToAdd = 10;
int insertIndex = 2;

functions.InsertElementAtIndex(array, insertIndex, elementToAdd, ref filledElements);

//Delete element at index n
functions.DeleteElementAtIndex(array, 4, ref filledElements);

//Binary Searching an array
functions.LinearSearch(array, 6);

//Arranging/Sortng eleements in Ascending
functions.BubbleSortElementsinAscending(array, ref filledElements);

//Arranging/Sortng eleements in Descending
functions.BubbleSortElementsinDescending(array, ref filledElements);

//Binary Search
int result = functions.BinarySearch(array, ref filledElements, 10);
functions.BinarySearchResult(result);

Console.WriteLine("Enter the number you want to check for Palindrome and Armstrong number");
int numToCheck= int.Parse(Console.ReadLine());

//Palindrome Check
PalindromeCheck palindromeCheck = new PalindromeCheck();
palindromeCheck.PalindromeCheckFunction(numToCheck);

//Armstrong Check
ArmstrongCheck armstrongCheck = new ArmstrongCheck();
armstrongCheck.ArmstrongCheckFunction(numToCheck);

*/

_66PlusOne test=new _66PlusOne();
int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
int[] newArray = test.PlusOne(array);

foreach (int i in newArray)
{
    Console.Write(" "+i);
}






