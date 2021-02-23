using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<string>();

            stack.Push("mahabubul");
            stack.Push("hasan");
            stack.Pop();
            stack.Push("uzzal");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
