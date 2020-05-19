using System;
using DataStructures.Stack;

namespace DataStructures
{
    public class PseudoQueue<T>
    {
        private Stack<T> stack1 = new Stack<T>();
        private Stack<T> stack2 = new Stack<T>();

        public PseudoQueue() { }

        public void Enqueue(T data)
        {

            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(data);

            while (!stack2.IsEmpty())
            {
                stack1.Push(stack2.Pop());
            }
        }

        public T Dequeue()
        {
            if (stack1.IsEmpty())
                throw new Exception("Queue is Empty");

            return stack1.Pop();
        }

        public T Peek()
        {
            return stack1.Peek();
        }
    }
}
