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
    }
    
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
