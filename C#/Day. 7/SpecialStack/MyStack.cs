namespace SpecialStack;

public class MyStack<T>
{
    private List<T> _items;
    
    public MyStack()
    {
        _items = new List<T>();
    }
    
    public int Count => _items.Count;

    public void Push(T item)
    {
        this._items.Add(item);
    }
    
    public T Pop()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("The stack is empty.");

        var item = _items[^1];
        _items.RemoveAt(_items.Count - 1);
        return item;
    }

    public T Peek
    {
        get
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("The stack is empty.");
            return _items[^1];
        }
    }
    
    public T Top => Peek;

    public void Clear()
    {
        _items.Clear();
    }
}