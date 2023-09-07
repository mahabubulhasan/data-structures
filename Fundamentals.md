## List
```C#
public class DynamicArray<T>
{
    private T[] array;
    private int count;

    public DynamicArray(int initialCapacity)
    {
        array = new T[initialCapacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == array.Length)
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        array[count] = item;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }
        return array[index];
    }

    public int Count
    {
        get { return count; }
    }
}
```

## Set 
```C#
public class DynamicSet<T>
{
    private T[] array;
    private int count;

    public DynamicSet(int initialCapacity)
    {
        array = new T[initialCapacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (Contains(item))
            return;

        if (count == array.Length)
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        array[count] = item;
        count++;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (array[i].Equals(item))
                return true;
        }
        return false;
    }

    public int Count
    {
        get { return count; }
    }
}
```

## Map
```C#
public class DynamicMap<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public DynamicMap(int initialCapacity)
    {
        keys = new TKey[initialCapacity];
        values = new TValue[initialCapacity];
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            TKey[] newKeys = new TKey[keys.Length * 2];
            TValue[] newValues = new TValue[values.Length * 2];
            for (int i = 0; i < keys.Length; i++)
            {
                newKeys[i] = keys[i];
                newValues[i] = values[i];
            }
            keys = newKeys;
            values = newValues;
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue Get(TKey key)
    {
        for (int i = 0; i < count; i++)
            if (keys[i].Equals(key))
                return values[i];

        throw new Exception("Key not found");
    }
}
```

## Queue
```C#
public class DynamicQueue<T>
{
    private T[] array;
    private int head;
    private int tail;
    private int count;

    public DynamicQueue(int initialCapacity)
    {
        array = new T[initialCapacity];
        head = 0;
        tail = 0;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == array.Length)
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[(head + i) % array.Length];
            }
            array = newArray;
            head = 0;
            tail = count;
        }
        array[tail] = item;
        tail = (tail + 1) % array.Length;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
            throw new Exception("Queue is empty");

        T item = array[head];
        head = (head + 1) % array.Length;
        count--;
        return item;
    }

    public int Count
    {
        get { return count; }
    }
}
```

## Stack
```C#
public class DynamicStack<T>
{
    private T[] array;
    private int count;

    public DynamicStack(int initialCapacity)
    {
        array = new T[initialCapacity];
        count = 0;
    }

    public void Push(T item)
    {
        if (count == array.Length)
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        array[count] = item;
        count++;
    }

    public T Pop()
    {
        if (count == 0)
            throw new Exception("Stack is empty");

        count--;
        return array[count];
    }

    public int Count
    {
        get { return count; }
    }
}
```
