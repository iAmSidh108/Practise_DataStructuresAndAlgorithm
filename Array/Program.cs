// See https://aka.ms/new-console-template for more information
using Array;

Console.WriteLine("Hello, World!");
int[] array = new int[10];

int filledElementsIndex=0;
//Filling elements till 5th index
for(int i=0; i<5; i++)
{
    array[i] = i+1;
    filledElementsIndex=i;

}

ArrayFunctions functions = new ArrayFunctions();

//Traverse elements of an array
functions.PrintAllElemntsInAnArray(array);

//Add element at nth index
functions.InsertElement(array, 3, 7, filledElementsIndex);
filledElementsIndex++;

//functions.InsertElement(array, 3, 9, filledElementsIndex);

