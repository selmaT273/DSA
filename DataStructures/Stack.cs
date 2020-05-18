using System;
namespace DataStructures
{
    public class Stack<T>
    {
        private Node top;

        public void Push(T value)
        {

        }

        public T Pop()
        {
            return default;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new ArgumentException();
            }

            return default;
        }

        private class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
        }
    }
}
