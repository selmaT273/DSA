using System;
namespace DataStructures.Queue
{
    public class Queue<T>
    {
        Node front;
        Node rear;

        public void Enqueue(T value)
        {
            if (rear == null)
            {
                rear = new Node(value);
                front = rear;
            }
            else
            {
                Node newValue = new Node(value);
                rear.Next = newValue;
                rear = newValue;
            }

        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new ArgumentException();
            }

            Node frontValue = front;
            front = front.Next;

            return frontValue.Value;
        }

        public T Peek()
        {
            if (front == null)
            {
                throw new ArgumentException();
            }

            return front.Value;
        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }

            return false;
        }

        public class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
            public Node(T value)
            {
                Value = value;
            }
        }

    }
}
