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

            Console.WriteLine("\nElements after Traversal");
            Traverse();
        }

        public void InsertionSort()
        {

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
