class Stack<T>
{
    List<T> list = new List<T>();
    public void Push(T item)
    {
        list.Add(item);
    }

    public T Pop()
    {
      
        {
            T sabr = list[list.Count - 1];
            list.Remove(list[list.Count - 1]);
            return sabr;
        }
    }
    public T Peek()
    {
        {
            return list[list.Count - 1];
        }
    }




}