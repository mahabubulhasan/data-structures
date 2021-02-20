using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    public class DynamcArray<T> : IEnumerable<T>
    {
        private T[] arr;
        private int len = 0;
        private int capacity = 0;

        public DynamcArray() : this(16) { }
        
        public DynamcArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException($"Illegal array capacity {capacity}");
            }

            this.capacity = capacity;
            var objArr = new object[capacity];
            arr = objArr.Cast<T>().ToArray();
        }

        public int Size()
        {
            return len;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public T Get(int index)
        {
            return arr[index];
        }

        public void Set(int index, T elem)
        {
            arr[index] = elem;
        }

        public void Clear()
        {
            for (int i = 0; i < capacity; i++)
            {
                arr[i] = default(T);
            }
            len = 0;
        }

        public void Add(T elem)
        {
            if(len + 1 > capacity)
            {
                if (capacity == 0)
                {
                    capacity = 1;
                }
                else
                {
                    capacity *= 2;
                }

                var obArr = new object[capacity];
                T[] newArr = obArr.Cast<T>().ToArray();

                for (int i = 0; i < capacity; i++)
                {
                    newArr[i] = arr[i];
                }

                arr = newArr;
            }

            arr[len++] = elem;
        }

        public T RemoveAt(int index)
        {
            if(index >= len && index > 0)
            {
                throw new IndexOutOfRangeException();
            }

            T data = arr[index];

            var obArr = new object[len-1];
            T[] newArr = obArr.Cast<T>().ToArray();

            for (int i = 0, j=0; i < len; i++, j++)
            {
                if (i == index)
                {
                    j--;
                }
                else
                {
                    newArr[j] = arr[i];
                }
            }
            arr = newArr;
            capacity = len--;
            return data;
        }

        public bool Remove(object obj)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (arr[i].Equals(obj))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (arr[i].Equals(obj))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(object obj)
        {
            return IndexOf(obj) != -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)arr).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        public override string ToString()
        {
            if (len == 0)
            {
                return "[]";
            }
            else
            {
                var sb = new StringBuilder(len).Append("[");
                for (int i = 0; i < len-1; i++)
                {
                    sb.Append($"{arr[i]}, ");
                }

                sb.Append($"{arr[len-1]}]");
                return sb.ToString();
            }
        }
    }
}
