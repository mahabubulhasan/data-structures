using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private int size = 0;
        private Node<T> head = null;
        private Node<T> tail = null;

        // Empty this linkedlist, O(n)
        public void Clear()
        {
            Node<T> trav = head;
            while (trav != null)
            {
                Node<T> next = trav.next;
                trav.next = trav.prev = null;
                trav.data = default(T);
                trav = next;
            }
            head = tail = trav = null;
            size = 0;
        }

        public int Size() => size;

        public bool IsEmpty() => size == 0;

        public void Add(T elem) => AddLast(elem);

        public void AddLast(T elem)
        {
            if (IsEmpty())
            {
                head = tail = new Node<T>(elem, null, null);
            }
            else
            {
                tail.next = new Node<T>(elem, tail, null);
                tail = tail.next;
            }

            size++;
        }

        public void AddFirst(T elem)
        {
            if (IsEmpty())
            {
                tail = head = new Node<T>(elem, null, null);
            }
            else
            {
                head.prev = new Node<T>(elem, null, head);
                head = head.prev;
            }

            size++;
        }

        public void AddAt(int index, T elem)
        {
            if (index < 0)
            {
                throw new ArgumentException("Illegal Index");
            }

            if (index == 0)
            {
                AddFirst(elem);
                return;
            }

            if (index == size)
            {
                AddLast(elem);
                return;
            }

            Node<T> temp = head;

            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }

            Node<T> newNode = new Node<T>(elem, temp, temp.next);
            temp.next.prev = newNode;
            temp.next = newNode;

            size++;
        }

        public T PeekFirst()
        {
            if (IsEmpty()) throw new NullReferenceException();
            return head.data;
        }

        public T PeekLast()
        {
            if (IsEmpty()) throw new NullReferenceException();
            return tail.data;
        }

        public T RemoveFirst()
        {
            if (IsEmpty()) throw new NullReferenceException();

            T data = head.data;
            head = head.next;
            size--;

            if (IsEmpty())
            {
                tail = null;
            }
            else
            {
                head.prev = null;
            }

            return data;
        }

        public T RemoveLast()
        {
            if (IsEmpty()) throw new NullReferenceException();

            T data = tail.data;
            tail = tail.prev;
            size--;

            if (IsEmpty())
            {
                head = null;
            }
            else
            {
                tail.next = null;
            }

            return data;
        }

        public T Remove(Node<T> node)
        {
            if (node.prev == null) RemoveFirst();
            if (node.next == null) RemoveLast();

            node.prev.next = node.next;
            node.next.prev = node.prev;

            T data = node.data;
            node.data = default;
            node.prev = node.next = null;
            size--;

            return data;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= size) throw new ArgumentException("Illegal Index");

            int i;
            Node<T> trav;

            if (index < size / 2)
            {
                for (i = 0, trav = head; i != index; i++)
                {
                    trav = trav.next;
                }
            }
            else
            {
                for (i = size - 1, trav = tail; i != index; i--)
                {
                    trav = trav.prev;
                }
            }

            return Remove(trav);
        }

        public bool Remove(object obj)
        {
            Node<T> trav = head;

            if (obj == null)
            {
                for (trav = head; trav != null; trav = trav.next)
                {
                    if (trav.data == null)
                    {
                        Remove(trav);
                        return true;
                    }
                }
            }
            else
            {
                for (trav = head; trav != null; trav = trav.next)
                {
                    if (obj.Equals(trav.data))
                    {
                        Remove(trav);
                        return true;
                    }
                }
            }

            return false;
        }

        public int IndexOf(object obj)
        {
            int index = 0;
            Node<T> trav = head;

            if(obj == null)
            {
                for (; trav!=null; trav = trav.next, index++)
                {
                    if (trav.data == null)
                    {
                        return index;
                    }
                }
            }
            else
            {
                for (; trav != null; trav = trav.next, index++)
                {
                    if (obj.Equals(trav.data))
                    {
                        return index;
                    }
                }
            }

            return -1;
        }

        public bool Contains(object obj) => IndexOf(obj) != -1;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NodeEnumerator<T>(head);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[");
            Node<T> trav = head;
            while (trav!=null)
            {
                sb.Append(trav.data);
                if (trav.next != null)
                {
                    sb.Append(", ");
                }
                trav = trav.next;
            }
            sb.Append("]");
            return sb.ToString();
        }
    }

    public class NodeEnumerator<T> : IEnumerator<T>
    {
        Node<T> head;
        Node<T> first;

        public NodeEnumerator(Node<T> head)
        {
            first = this.head = head;
        }

        public T Current => head.data;

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            Node<T> start = head;
            while (start != null)
            {
                start.data = default;
                start.prev = null;
                start = start.next;
            }
        }

        public bool MoveNext()
        {
            head = head.next;
            if (head != null)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            head = first;
        }
    }
}
