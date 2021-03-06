﻿using System;

namespace StackNQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Implementaion!");

            StackOperation stackop = new StackOperation();
            stackop.Push(56);
            stackop.Push(30);
            stackop.Push(70);
            stackop.Display();
            stackop.Peek();
            stackop.Pop();
            stackop.isEmpty();

            QueueOperation queueop = new QueueOperation();
            queueop.Enqueue(56);
            queueop.Enqueue(30);
            queueop.Enqueue(70);
            queueop.Display();
            queueop.Dequeue();
            queueop.isEmpty();
        }
    }
}
