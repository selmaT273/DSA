using System;

namespace DataStructures
{ 
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

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
                    list += "{ ";
                    list += current.ToString();
                    current = current.Next;
                    if (current != null)
                    {
                        list += " } -> ";
                    }
                    
                }

                list += " } -> NULL";

                return list;
            }

        }


        public void Insert(int value)
        {
            if(Head == null)
            {
                Head = new Node(value);
                Tail = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                node.Next = Head;
                Head = node;
            }
        }

        public bool Includes(int value)
        {
            if(Head != null)
            {
                Node current = Head;

                while (current != null)
                {
                    if (current.Data == value)
                    {
                        return true;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void Append(int value)
        {
            if (Tail == null)
            {
                Head = new Node(value);
                Tail = new Node(value);
            }
            else
            {
                Node node = new Node(value);
                Tail.Next = node;
                Tail = node;
            }
        }

        public void InsertBefore(int value, int newValue)
        {


            if (Head == null)
            {
                throw new ArgumentException($"{value} not found in Linked List");
            }

            if (Head.Data == value)
            {
                Insert(newValue);
            }
            else
            {
                Node current = Head;
                bool found = false;

                while (current.Next != null)
                {

                    if (current.Next.Data == value)
                    {
                        Node oldNext = current.Next;
                        current.Next = new Node(newValue);
                        current.Next.Next = oldNext;
                        found = true;
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if (!found)
                {
                    throw new ArgumentException($"{value} not found in Linked List");
                }
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
