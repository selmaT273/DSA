using System;

namespace DataStructures
{ 
    public class LinkedList
    {
        public Node Head { get; set; }

        public override string ToString()
        {
            if (Head == null)
            {
                return "";
            }
            else
            {
                return Head.ToString();
            }

        }

        public void Insert(int value)
        {
            this.Head = new Node(value);
        }
    }
    
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }
        public Node(int value)
        {
            Data = value;
            Next = null;
        }

    }
}
