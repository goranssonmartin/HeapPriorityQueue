using System;
using HeapPriorityQueue;
using IPriorityQueue;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueueTester.TestPriorityQueue(() => new HeapPriorityQueueHandler<int>(), () => new HeapPriorityQueueHandler<string>());
            Console.ReadLine();
        }
    }
}
