using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class QueueArray
    {
        private readonly int capacity;
        private int[] items;
        private int rear;
        private int front;

        public QueueArray(int capacity)
        {
            this.capacity = capacity;
            items = new int[capacity];
        }

        public int Size { get; private set; }

        public void Enqueue(int item)
        {
            items[rear] = item;
            rear = (rear + 1) % capacity;
            Size++;
        }

        public int Dequeue()
        {
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % capacity;
            Size--;
            return item;
        }

        public override string ToString()
        {
            return string.Join(',', items);
        }
    }
}
