using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BasicBinaryTree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);

            var tree2 = new BasicBinaryTree();
            tree2.Insert(7);
            tree2.Insert(4);
            tree2.Insert(9);
            tree2.Insert(1);
            tree2.Insert(6);
            tree2.Insert(8);
            tree2.Insert(10);

            Console.WriteLine($"Find 9 {tree.Find(9)}");
            Console.WriteLine($"Find 3 {tree.Find(3)}");

            Console.WriteLine("\nPre Order");
            tree.TraversePreOrder();

            Console.WriteLine("\nIn Order");
            tree.TraverseInOrder();

            Console.WriteLine("\nPost Order");
            tree.TraversePostOrder();

            Console.WriteLine($"\nTree Height: {tree.Height()}");

            Console.WriteLine($"\nMinimum value in the tree: {tree.Min()}");

            Console.WriteLine($"\nEquality check: {tree.Equals(tree2)}");

            // tree.SwapRoot();
            Console.WriteLine($"\nIs valid Binary Search Tree: {tree.IsBinarySearchTree()}");

            Console.WriteLine("Print nodes at distance");
            foreach (var item in tree.PrintNodesAtDistance(2))
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\nTraverse Level Order");
            tree.TraverseLevelOrder();
        }
    }
}
