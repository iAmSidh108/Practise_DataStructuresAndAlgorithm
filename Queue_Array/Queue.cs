using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Array
{
    internal class Queue
    {
        int size;
        int[] array;
        int front;
        int rear;

        public Queue(int size) 
        {
            this.size = size;
            array= new int[size];
            front = 0;
            rear = -1;
        }

        public void Traverse()
        {
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return rear == -1;
        }

        public bool IsFull()
        {
            return rear == size - 1;
        }
        
    }
}
