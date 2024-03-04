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

        public void InsertElement(int[] array, int index, int elementToAdd, int filledIndex)
        {
            //if (filledIndex == array.Length)
            //{
            //    Console.Write("Couldnot fill the value as no space available \n");
            //    return;
            //}

            for (int i = index; i <=filledIndex; i++)
            {
                array[i + 1] = array[i];
            }

            array[index] = elementToAdd;
            filledIndex++;

            PrintAllElemntsInAnArray(array);
        }
    }
}
