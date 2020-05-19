using System;
namespace DataStructures.Stack
{
    public class Stack<T>
    {
        private Node top;

        public void Push(T value)
        {
            Node newValue = new Node(value);
            newValue.Next = top;
            top = newValue;
        }

        public T Pop()
        {
            if (top == null)
            {
                throw new ArgumentException();
            }

            Node topValue = top;
            top = top.Next;

            return topValue.Value;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new ArgumentException();
            }

            return top.Value;
        }

        public bool IsEmpty()
        {
            if (top == null)
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
