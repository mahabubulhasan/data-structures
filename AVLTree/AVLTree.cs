using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    class AVLTree
    {
        private AVLNode root;

        public void Insert(int value) => root = Insert(root, value);

        private AVLNode Insert(AVLNode node, int value)
        {
            if (node == null)
            {
                return new AVLNode(value);
            }

            if (value < node.value)
            {
                node.leftChild = Insert(node.leftChild, value);
            }
            else
            {
                node.rightChild = Insert(node.rightChild, value);
            }

            SetHeight(node);

            return Balance(node);
        }

        private void SetHeight(AVLNode node)
        {
            node.height = Math.Max(Height(node.leftChild), Height(node.rightChild)) + 1;
        }

        private AVLNode Balance(AVLNode node)
        {
            if (IsLeftHeavy(node))
            {
                if(BalanceFactor(node.leftChild) < 0)
                {
                    node.leftChild = RotateLeft(node.leftChild);
                }

                return RotateRight(node);
            }
            else if (IsRightHeavy(node))
            {
                if(BalanceFactor(node.rightChild) > 0)
                {
                    node.rightChild = RotateRight(node.rightChild);
                }

                return RotateLeft(node);
            }

            return node;
        }

        private bool IsLeftHeavy(AVLNode node) => BalanceFactor(node) > 1;
        private bool IsRightHeavy(AVLNode node) => BalanceFactor(node) < -1;
        private int BalanceFactor(AVLNode node) => (node == null) ? 0 : Height(node.leftChild) - Height(node.rightChild);

        private AVLNode RotateLeft(AVLNode node)
        {
            var newRoot = node.rightChild;
            node.rightChild = newRoot.leftChild;
            newRoot.leftChild = node;

            SetHeight(newRoot);
            SetHeight(node);

            return newRoot;
        }

        private AVLNode RotateRight(AVLNode node)
        {
            var newRoot = node.leftChild;
            node.leftChild = newRoot.rightChild;
            newRoot.rightChild = node;

            SetHeight(newRoot);
            SetHeight(node);

            return newRoot;
        }

        private int Height(AVLNode node)
        {
            if (node == null) return -1;
            return node.height;
        }

        private class AVLNode
        {
            public readonly int value;
            public AVLNode leftChild;
            public AVLNode rightChild;
            public int height;

            public AVLNode(int value)
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
