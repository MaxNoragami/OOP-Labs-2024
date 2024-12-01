namespace lab3.Task4
{
    public class CircularQueue<T> : IQueue<T>
    {
        // Attributes
        private T[] queue;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        // Constructor
        public CircularQueue(int size)
        {
            queue = new T[size];
            front = 0;
            rear = -1;
            this.size = 0;
            capacity = size;
        }

        // Interface implementations
        public T? Dequeue()
        {
            if (size == 0) return default;
            T element = queue[front];
            front = (front + 1) % capacity;
            size--;
            return element;
        }

        public void Enqueue(T t)
        {
            if (size == capacity) throw new InvalidOperationException("Queue is full.");
            rear = (rear + 1) % capacity;
            queue[rear] = t;
            size++;
        }

        public T? Peek()
        {
            if(size == 0) return default;
            return queue[front];
        }

        public int Size()
        {
            return size;
        }
    }
}