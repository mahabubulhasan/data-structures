using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamcArray<string> da = new DynamcArray<string>();

            da.Add("Hello");
            da.Add("Great");
            da.Add("World");

            Console.WriteLine(da);
            Console.WriteLine($"Array Size {da.Size()}");

            foreach (var item in da)
            {
                Console.WriteLine(item);
            }
        }
    }
}
