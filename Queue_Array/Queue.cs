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
            front = 0;
            rear = 0;
        }

        public void Traverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing to Traverse, Queue is Empty.");
            }
            else
            {
                int current = front+1;
                Console.WriteLine("The elements in queue currently are: ");
                while (current != rear)
                {
                    Console.Write(array[current] + " ");
                    current = (current + 1) % size;
                }
                Console.Write(array[current] + " "); // Print the last element

                Console.WriteLine();
            }
            
        }

        public bool IsEmpty()
        {
            return rear==front;
        }

        public bool IsFull()
        {
            return (rear + 1) % size == front;
        }

        public void Enqueue(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Can't Enqueue, Queue is Full.");
            }
            else
            {
                rear= (rear + 1) % size;
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

                front = (front + 1) % size;
                Console.WriteLine($"The element from front has been dequeued.");
                
            }
            
        }

        public void PeekFront()
        {
            Console.WriteLine(array[front+1]);
        }

        public void PeekRear()
        {
            Console.WriteLine(array[rear]);
        }



    }
}
