using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Heap
    {
        public int[] items = new int[10];
        int size = 0;

        public void Insert(int value)
        {
            if (IsFull()) throw new IndexOutOfRangeException();

            items[size++] = value;

            BubbleUp();
        }

        private void BubbleUp()
        {
            var current = size - 1;
            while (current > 0 && items[current] > items[Parent(current)])
            {
                Swap(current, Parent(current));
                current = Parent(current);
            }
        }

        private bool IsFull() => size == items.Length;
        private int Parent(int index) => (index - 1) / 2;

        /// <summary>
        /// Swap array items based on their index
        /// </summary>
        /// <param name="first">Index of first item</param>
        /// <param name="second">Index of second item</param>
        private void Swap(int first, int second) => (items[first], items[second]) = (items[second], items[first]);

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new OutOfMemoryException();
            }

            var output = items[0];
            items[0] = items[--size];
            BubbleDown();

            return output;
        }

        public bool IsEmpty() => size == 0;

        private void BubbleDown()
        {
            var index = 0;
            while (index < size && !IsValidParent(index))
            {
                int largerChildIndex = LargerChildIndex(index);
                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int LargerChildIndex(int index)
        {
            if (!HasLeftChild(index)) 
            {
                return index;
            }

            if (!HasRightChild(index))
            {
                return LeftChildIndex(index);
            }

            return (LeftChild(index) > RightChild(index)) ? LeftChildIndex(index) : RightChildIndex(index);
        }

        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
            {
                return true;
            }
            var isValid = items[index] >= LeftChild(index);

            if (HasRightChild(index))
            {
                isValid &= items[index] >= RightChild(index);
            }

            return isValid;
        }

        private int LeftChild(int index) => items[LeftChildIndex(index)];
        private int RightChild(int index) => items[RightChildIndex(index)];

        private bool HasLeftChild(int index) => LeftChildIndex(index) <= size;
        private bool HasRightChild(int index) => RightChildIndex(index) <= size;

        private int LeftChildIndex(int index) => (index * 2) + 1;
        private int RightChildIndex(int index) => (index * 2) + 2;
    }
}
