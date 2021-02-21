namespace LinkedList
{
    public class Node<T>
    {
        internal T data;
        internal Node<T> prev, next;

        public Node(T data, Node<T> prev, Node<T> next)
        {
            this.data = data;
            this.prev = prev;
            this.next = next;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
