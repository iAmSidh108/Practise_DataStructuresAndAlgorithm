using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            front = -1;
            rear = -1;
        }

        public void Traverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing to Traverse, Queue is Empty.");
            }
            else
            {
                Console.WriteLine("The elements in queue currently are: ");
                for (int i = 0; i <= rear; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            
        }

        public bool IsEmpty()
        {
            return rear == front;
        }

        public bool IsFull()
        {
            return rear == size - 1;
        }

        public void Enqueue(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Can't Enqueue, Queue is Full.");
            }
            else
            {
                rear++;
                array[rear] = element;

                Console.WriteLine($"The {element} has been added to Queue.");
                
            }
            
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Can't Dequeue, Queue is empty.");
            }
            else
            {
                //int removedElement = array[front];

                front++;
                Console.WriteLine($"The element from front has been dequeued.");
                
            }
            
        }
        
    }
}
