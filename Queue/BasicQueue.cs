using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class BasicQueue<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> list = new LinkedList<T>();

        public BasicQueue()
        {
        }

        public BasicQueue(T firstElement)
        {
            Offer(firstElement);
        }

        public int Size() => list.Count;

        public bool IsEmpty() => Size() == 0;

        public T PeekFirst()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }

            return list.First.Value;
        }

        public T Poll()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException();
            }

            var val = list.First.Value;
            list.RemoveFirst();
            return val;
        }

        public void Offer(T elem)
        {
            list.AddLast(elem);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
