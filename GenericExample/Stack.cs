namespace GenericExample;

public class Stack<T>
{
    private List<T> elements;

    public Stack()
    {
        elements = new List<T>();
    }

    public void Push(T item)
    {
        elements.Add(item);
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public int Count
    {
        get { return elements.Count; }
    }
}
