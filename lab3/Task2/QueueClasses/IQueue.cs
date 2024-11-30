namespace lab3.Task2
{
    public interface IQueue<T>
    {
        public void Enqueue(T t);
        public T? Dequeue();
        public T? Peek();
        public int Size();
    }
}