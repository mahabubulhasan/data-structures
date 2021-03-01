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

        }
    }
}
