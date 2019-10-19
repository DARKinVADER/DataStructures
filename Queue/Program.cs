using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.EnQueue(10);
            queue.EnQueue(20);
            queue.DeQueue();
            queue.DeQueue();
            queue.EnQueue(30);
            queue.EnQueue(40);
            queue.EnQueue(50);

            Console.WriteLine("Dequeued item is " + queue.DeQueue().Data);
        }
    }
}
