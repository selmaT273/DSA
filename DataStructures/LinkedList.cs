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
                Node current = Head;
                string list = "";

                while(current != null)
                {
                    list += current.ToString();
                    current = current.Next;
                    if (current != null)
                    {
                        list += " ";
                    }

                }

                return list;
            }

        }

        public void Insert(int value)
        {
            if(Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                node.Next = Head;
                Head = node;
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
        public Node(int value)
        {
            Data = value;
            Next = null;
        }

    }
}
