using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueueDemo
{
    class QueueOperation
    {
         Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;                
            }
            Console.WriteLine(node.data + " inserted in queue");
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Empty queue");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
}
