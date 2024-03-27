using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class AlgoCode
    {
        int[] array;
        public AlgoCode(int[] array)
        {
            this.array = array;
        }

        public void BubbleSort()
        {
            // Best Case= O(n)  = When array is sorted
            //Worst Case= O(n2) =When array is not sorted
            //Stability: Stable
            //Adaptability: Not adaptive

            int n =array.Length;
            bool isSorted = false;

            Console.WriteLine("\nElements before Traversal");
            Traverse();

            for (int i = 0; i < n-1; i++)
            {
                isSorted = true;

                for (int j = 0; j<n-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        //Created this function below
                        Swap(array, j, j + 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
            }

            Console.WriteLine("\nElements after Traversal using Bubble Sort.");
            Traverse();
        }

        public void InsertionSort()
        {
            // Best Case= O(n)  = When array is sorted
            //Worst Case= O(n2) =When array is not sorted
            //Stability: Stable
            //Adaptability: Adaptive

            Console.WriteLine("\nElements before Traversal");
            Traverse();

            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            Console.WriteLine("\nElements after Traversal using Insertion Sort.");
            Traverse();
        }

        public void SelectionSort()
        {
            // Best Case= O(n2)  = When array is sorted
            //Worst Case= O(n2) =When array is not sorted
            //Not Stable
            //Isn't Adaptive
            //Sorting in minimum number of swap

            Console.WriteLine("\nElements before Traversal");
            Traverse();
            int indexOfMin;
            for (int i = 0; i < array.Length-1; i++)
            {
                indexOfMin = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }

                //Created this function below
                Swap(array, indexOfMin, i);
                
            }
            Console.WriteLine("\nElements after Traversal using Selection Sort.");
            Traverse();
        }

        #region Quick Sort
        public void QuickSort()
        {
            //Worst Case: O(n2)- When array is sorted already
            //Best Case: O(nlogn)- When the pivot chosen is always the median element of the partitioned array
            //Stability: Not Stable
            //Adaptibility: Not Adaptive

            Console.WriteLine("\nElements before Traversal");
            Traverse();

            QuickSortRecursive(array, 0, array.Length-1);

            Console.WriteLine("\nElements after Traversal using Quick Sort.");
            Traverse();

        }

        void QuickSortRecursive(int[] A, int low, int high)
        {
            
            int partitionIndex; // Index of pivot after partition

            if (low < high)
            {
                partitionIndex = Partition(A, low, high);
                QuickSortRecursive(A, low, partitionIndex - 1);  // sort left subarray 
                QuickSortRecursive(A, partitionIndex + 1, high); // sort right subarray
            }

        }

        int Partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            int temp;

            do
            {
                while (A[i] <= pivot)
                {
                    i++;
                }

                while (A[j] > pivot)
                {
                    j--;
                }

                if (i < j)
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            } while (i < j);


            Swap(A,low, j);
            return j;
        }

        #endregion

        public void Traverse()
        {
            foreach (int num in array)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }

        void Swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp= array[firstIndex];
            array[firstIndex]= array[secondIndex];
            array[secondIndex]= temp;

        }
    }
}
