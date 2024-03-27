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
            int n=array.Length;
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
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;

                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
            }

            Console.WriteLine("\nElements after Traversal using Bubble Sort");
            Traverse();
        }

        public void InsertionSort()
        {
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

            Console.WriteLine("\nElements after Traversal using Insertion Sort");
            Traverse();
        }

        public void Traverse()
        {
            foreach (int num in array)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }
    }
}
