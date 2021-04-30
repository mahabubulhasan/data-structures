using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class PriorityQueue
    {
        private int[] items = new int[5];
        private int count = 0;

        public void Enqueue(int item)
        {
            int i;
            for (i = count-1; i >= 0; i--)
            {
                if (item < items[i])
                {
                    items[i + 1] = items[i];
                }
                else
                {
                    break;
                }
            }

            items[i + 1] = item;
            count++;
        }

        public int Dequeu()
        {
            var item = items[count-1];
            items[count - 1] = 0;
            count--;
            return item;
        }

        public override string ToString()
        {
            return string.Join(',', items);
        }
    }
}
