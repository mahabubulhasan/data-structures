using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var dl = new DoublyLinkedList<string>();

            dl.Add("Hello");
            dl.Add("Great");
            dl.Add("World");

            Console.WriteLine(dl);

            // dl.RemoveAt(1);

            foreach (var item in dl)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Size {dl.Size()}");
        }
    }
}
