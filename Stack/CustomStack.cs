using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T>: IEnumerable<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public CustomStack()
        {
        }

        public CustomStack(T elem)
        {
            Push(elem);
        }

        public int Size() => list.Count;

        public bool IsEmpty() => list.Count == 0;

        public void Push(T elem) => list.AddLast(elem);

        public T Pop()
        {
            if (IsEmpty()) throw new NullReferenceException();
            var value = list.Last.Value;
            list.RemoveLast();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new NullReferenceException();
            return list.Last.Value;
        }

        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
