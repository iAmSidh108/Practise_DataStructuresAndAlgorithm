using Array;
using System.Diagnostics;

int arrayLength = 10; // Define the length of the array
int[] array = new int[arrayLength];
int filledElements = 7; // Example: assume 5 elements are already filled

// Populate the array with some initial values
for (int i = 0; i < filledElements; i++)
{
    array[i] = i + 1; // Filling the array with values 1, 2, 3, 4, 5
}

ArrayFunctions functions = new ArrayFunctions();

// Display the array before insertion
Console.WriteLine("Array before insertion:");
functions.PrintAllElemntsInAnArray(array);

// Insert an element at the 3rd index (index 2)
int elementToAdd = 10;
int insertIndex = 2;

functions.InsertElementAtIndex(array, insertIndex, elementToAdd, ref filledElements);

functions.DeleteElementAtIndex(array, 4, ref filledElements);
