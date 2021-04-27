using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap();
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(17);
            heap.Insert(4);
            heap.Insert(22);
            
            Console.WriteLine(string.Join(',', heap.items));
            Console.WriteLine($"Removed: {heap.Remove()}"); 
        }
    }
}
