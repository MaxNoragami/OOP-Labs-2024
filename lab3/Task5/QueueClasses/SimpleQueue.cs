namespace lab3.Task5
{
    public class SimpleQueue<T> : IQueue<T>
    {
        private List<T> queue = new List<T>();
        
        public T? Dequeue()
        {   
            
            if (queue.Count == 0) return default;

            T element = queue[0];
            queue.RemoveAt(0);
            return element;
        }

        public void Enqueue(T t)
        {
            queue.Add(t);
        }

        public T? Peek()
        {
            return queue.FirstOrDefault();
        }

        public int Size()
        {
            return queue.Count;
        }
    }
}