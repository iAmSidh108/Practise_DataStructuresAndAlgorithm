using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked
{
    internal class LinkedQueue
    {
        QueueNode rear;
        QueueNode front;

        public bool IsEmpty()
        {
            return rear == null && front == null;
        }


        public bool IsFull()
        {
            //Console.WriteLine("Queue using Linked List can not be full");
            return false;
        }

        public void Enqueue(int elementValue)
        {
            QueueNode newNode=new QueueNode(elementValue);

            if (IsEmpty())
            {
                front = rear=newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            Console.WriteLine($"{elementValue} has been enqueued in the queue.");
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
            }
            else
            {
                int dequeuedData = front.GetDataValue();

                front= front.next;
                if (front == null)
                {
                    rear = null;
                }

                Console.WriteLine($"{dequeuedData} has been removed from queue.");
            }
        }

        public void Traverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is empty nothing to traverse.");
            }
            else
            {
                QueueNode current = front;
                Console.WriteLine("The values in the Queue are:");
                while (current != null)
                {
                    Console.Write(current.GetDataValue()+" ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

        public void PeekFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot peek front.");
                
            }

            Console.WriteLine($"Front element of the queue: {front.GetDataValue()}");
            
        }

        public void PeekRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot peek rear.");

            }

            Console.WriteLine($"Front element of the queue: {rear.GetDataValue()}");

        }
    }
}
