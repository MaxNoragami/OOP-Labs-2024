namespace lab3.Task2
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        // Nested class Node, represents a single element in the list
        private class Node
        {
            public T Data {get;set;}
            public Node? Next {get; set;}

            public Node(T newData)
            {
                Data = newData;
                Next = null;
            }
        }

        // Attributes
        private Node? front;  // Start of the queue
        private Node? rear;  // End of the queue
        private int size;

        // Constructor
        public LinkedListQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        // Interface implementation
        public T? Dequeue()
        {
            // The queue is empty
            if(front == null) return default;

            T data = front.Data;
            front = front.Next;

            // If queue is now empty
            if(front == null) rear = null;
            size--;

            return data;
        }

        public void Enqueue(T t)
        {
            Node newNode = new Node(t);
            if(rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode; // Linking the last node to the newly added one 
                rear = newNode; // Updating the rear to point to the new last node
            }
            size++;
        }

        public T? Peek()
        {
            if(front == null) return default;
            return front.Data;
        }

        public int Size()
        {
            return size;
        }

    }
}