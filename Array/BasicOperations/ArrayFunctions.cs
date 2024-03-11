using System;
using System.Collections;
using System.Security.Cryptography;

namespace Array.BasicOperations
{
    public class ArrayFunctions
    {
        public void PrintAllElemntsInAnArray(int[] array)
        {
            foreach (int elemnt in array)
            {
                Console.Write(elemnt + " ");
            }
            Console.WriteLine();
        }



        public void InsertElementAtIndex(int[] array, int index, int elementToAdd, ref int filledIndex)
        {
            if (filledIndex >= array.Length || index < 0 || index > array.Length - 1)
            {
                Console.WriteLine("Invalid index for insertion.");
                return;
            }

            // Shift existing elements one index further
            for (int i = filledIndex - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }

            // Place the element at the nth location
            array[index] = elementToAdd;
            filledIndex++;

            PrintAllElemntsInAnArray(array);
            Console.WriteLine($"The element {elementToAdd} is added at {index} index.");
            Console.WriteLine();
        }

        public void DeleteElementAtIndex(int[] array, int index, ref int filledIndex)
        {
            // Shift remaining elements one index below the deleted position
            for (int i = index; i < filledIndex - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // Clear the last element to signify the deletion
            array[filledIndex - 1] = 0;

            filledIndex--;

            PrintAllElemntsInAnArray(array);
            Console.WriteLine($"The element at {index} index is deleted");
            Console.WriteLine();
        }

        public void LinearSearch(int[] array, int elementsToSearch)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == elementsToSearch)
                {
                    Console.WriteLine($"{elementsToSearch} is found at {i} index");
                }
            }
            Console.WriteLine();
        }

        public void BubbleSortElementsinAscending(int[] array, ref int filledIndex)
        {
            for (int i = 0; i < filledIndex - 1; i++)
            {
                for (int j = 0; j < filledIndex - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap elements if they are in the wrong order
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }


            PrintAllElemntsInAnArray(array);
            Console.WriteLine("The elements are sorted in ascending order.");
            Console.WriteLine();
        }

        public void BubbleSortElementsinDescending(int[] array, ref int filledIndex)
        {
            for (int i = 0; i < filledIndex - 1; i++)
            {
                for (int j = 0; j < filledIndex - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        // Swap elements if they are in the wrong order
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            PrintAllElemntsInAnArray(array);
            Console.WriteLine("The elements are sorted in descending order.");
            Console.WriteLine();
        }

        //public void BinarySearchAscending(int[] array, ref int filledIndex, int elementsToSearch)
        //{
        //    BubbleSortElementsinAscending(array, ref filledIndex);

        //    int left = 0;
        //    int right = array.Length - 1;


        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (array[mid] == elementsToSearch)
        //            Console.WriteLine($"Found element {elementsToSearch} at {mid} index.");


        //        if (array[mid] < elementsToSearch)
        //            left = mid + 1;
        //        else
        //            right = mid - 1;


        //    }
        //    Console.WriteLine();
        //}

        //public void BinarySearchDescending(int[] array, ref int filledIndex, int elementsToSearch)
        //{
        //    BubbleSortElementsinDescending(array, ref filledIndex);

        //    int left = 0;
        //    int right = array.Length - 1;

        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;

        //        if (array[mid] == elementsToSearch)
        //            Console.WriteLine($"Found element {elementsToSearch} at {mid} index.");

        //        if (array[mid] < elementsToSearch)
        //            right = mid - 1;
        //        else
        //            left = mid + 1;
        //    }
        //    Console.WriteLine();
        //}

        public int BinarySearch(int[] array, ref int filledIndex, int elementsToSearch)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array Empty."); // Not found in empty array
            }

            BubbleSortElementsinAscending(array, ref filledIndex);

            int low = 0;
            int high = array.Length - 1;

            for (int i = 0; low <= high; i++)
            {
                int mid = (low + high) / 2;

                if (array[mid] == elementsToSearch)
                {
                    // Found at index mid
                    return mid;
                }
                else if (array[mid] < elementsToSearch)
                {
                    low = mid; // Search in the right half
                }
                else
                {
                    high = mid; // Search in the left half
                }
            }
            return -1;


        }

        public void BinarySearchResult(int result)
        {
            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine($"Elements found at {result} index.\n");
            }
        }




    }
}
