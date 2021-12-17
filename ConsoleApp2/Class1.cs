using System;
using System.Collections.Generic;


namespace queue
{
    public class Deque<T>
    {
        private LinkedList<T> Link_List = new LinkedList<T>();

        public delegate void CollHandler(string message);                   //event declaration
        public event CollHandler Notify;

        public void EnqueueFirst(T item)
        {
            Link_List.AddFirst(item);
            Notify?.Invoke($"Item {item} has been added as the first one");
        }

        public void EnqueueLast(T item)
        {
            Link_List.AddLast(item);
            Notify?.Invoke($"Item {item} has been added as the last one");
        }

        public T DequeueFirst()
        {
            if(Link_List.Count == 0)
            {
                throw new InvalidOperationException("DequeueFirst called when deque is empty");
            }

            T temp = Link_List.First.Value;
            Notify?.Invoke($"The first item {Link_List.First.Value} has been removed");
            Link_List.RemoveFirst();
            return temp;
        }

        public T DequeueLast()
        {
            if (Link_List.Count == 0)
            {
                throw new InvalidOperationException("DequeueLast called when deque is empty");
            }

            T temp = Link_List.Last.Value;
            Notify?.Invoke($"The last item {Link_List.Last.Value} has been removed");
            Link_List.RemoveLast();
            return temp;
        }

        public T PeekFirst()
        {
            if (Link_List.Count == 0)
            {
                throw new InvalidOperationException("PeekFirst called when deque is empty");
            }

            Notify?.Invoke($"The first item {Link_List.First.Value} has been peeked");
            return Link_List.First.Value;
        }

        public T PeekLast()
        {
            if (Link_List.Count == 0)
            {
                throw new InvalidOperationException("PeekLast called when deque is empty");
            }

            Notify?.Invoke($"The last item {Link_List.Last.Value} has been peeked");
            return Link_List.Last.Value;
        }

        public int Count()
        {
            return Link_List.Count;
        }

        public void Clear()
        { 
            Link_List.Clear();
            Notify?.Invoke($"The collection has been deleted");
        }

    }
}
