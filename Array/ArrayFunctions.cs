using System.Diagnostics;

namespace Array
{
    public class ArrayFunctions
    {
        public void PrintAllElemntsInAnArray(int[] array)
        {
            foreach (int elemnt in array)
            {
                Console.Write(elemnt+" ");
            }
            Console.WriteLine();
        }

        public void InsertElementAtIndex(int[] array, int index, int elementToAdd, ref int filledIndex)
        {
            if (filledIndex >= array.Length || index < 0 || index > array.Length-1)
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
        }

        


    }
}
