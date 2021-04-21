using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BasicBinaryTree
    {
        Node root;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {
                if (current.value > value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find(int value)
        {
            var current = root;
            if (current.value == value)
            {
                return true;
            }

            while (current != null)
            {
                if (current.value > value)
                {
                    current = current.leftChild;
                }
                else if (current.value < value)
                {
                    current = current.rightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void TraversePreOrder() => TraversePreOrder(root);

        public void TraverseInOrder() => TraverseInOrder(root);

        public void TraversePostOrder() => TraversePostOrder(root);

        private void TraversePreOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root.value + ", ");
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        private void TraverseInOrder(Node root)
        {
            if (root == null) return;
            TraverseInOrder(root.leftChild);
            Console.Write(root.value + ", ");
            TraverseInOrder(root.rightChild);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null) return;
            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.Write(root.value + ", ");
        }

        public int Height() => Height(root);

        private int Height(Node root)
        {
            if (root == null) return -1;
            if (root.leftChild == null && root.rightChild == null) return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        private bool IsLeaf(Node node) => node.leftChild == null && node.rightChild == null;

        public int Min() => Min(root);

        private int Min(Node root)
        {
            if (root == null) return int.MaxValue;

            if (IsLeaf(root))
            {
                return root.value;
            }

            var left = Min(root.leftChild);
            var right = Min(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value);
        }

        public bool Equals(BasicBinaryTree other) => Equals(root, other.root);

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null) return true;
            if (first != null && second != null)
            {
                return first.value == second.value
                    && Equals(first.leftChild, second.leftChild)
                    && Equals(first.rightChild, second.rightChild);
            }

            return false;
        }

        public bool IsBinarySearchTree() => IsBinarySearchTree(root, int.MinValue, int.MaxValue);

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null) return true;

            if (root.value < min || root.value > max) return false;

            return IsBinarySearchTree(root.leftChild, min, root.value - 1)
                    && IsBinarySearchTree(root.rightChild, root.value + 1, max);
        }

        public void SwapRoot()
        {
            var temp = root;
            root = root.leftChild; ;
            root.leftChild = temp;
        }

        public List<int> PrintNodesAtDistance(int distance)
        {
            var list = new List<int>();
            PrintNodesAtDistance(root, distance, list);
            return list;
        }

        private void PrintNodesAtDistance(Node root, int distance, List<int> list)
        {
            if (root == null) return;
            if (distance == 0)
            {
                list.Add(root.value);
                return;
            }
            PrintNodesAtDistance(root.leftChild, distance - 1, list);
            PrintNodesAtDistance(root.rightChild, distance - 1, list);

        }

        public void TraverseLevelOrder()
        {
            for (int i = 0; i <= Height(); i++)
            {
                foreach (var item in PrintNodesAtDistance(i))
                {
                    Console.Write(item + " ,");
                }
            }
        }

        private class Node
        {
            public readonly int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return $"Node = {value}";
            }
        }
    }
}
