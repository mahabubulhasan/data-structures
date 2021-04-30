using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicQueue = new BasicQueue<string>("Hello");
            basicQueue.Offer("Magical");
            basicQueue.Offer("World");
            basicQueue.Offer("of");
            basicQueue.Offer("Data Structures");

            foreach (var item in basicQueue)
            {
                Console.WriteLine(item);
            }

            var queue = new QueueArray(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(40);
            Console.WriteLine(queue);

            Console.WriteLine("\nPriority Queue");
            var pq = new PriorityQueue();
            pq.Enqueue(5);
            pq.Enqueue(3);
            pq.Enqueue(6);
            pq.Enqueue(1);
            pq.Enqueue(4);
            Console.WriteLine(pq);
            pq.Dequeu();
            Console.WriteLine(pq);
        }
    }
}
