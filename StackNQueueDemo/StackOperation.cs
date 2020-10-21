using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueueDemo
{
    class StackOperation
    {
        private Node top;
        public StackOperation()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " Pushed to stack");
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }
            Console.WriteLine(this.top.data + " is the top");
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty!");
            }
            Console.WriteLine("Value popped is: " + this.top.data);
            this.top = this.top.next;
        }
        internal void isEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
