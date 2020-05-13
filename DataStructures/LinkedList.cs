using System;

namespace DataStructures
{ 
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Length { get; set; }

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
            Length += 1;
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
                Tail = Head;
            }
            else
            {
                Node node = new Node(value);
                Tail.Next = node;
                Tail = node;
            }
            Length += 1;
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
                Length += 1;
            }
            
                
        }

        public void InsertAfter(int value, int newValue)
        {


            if (Head == null)
            {
                throw new ArgumentException($"{value} not found in Linked List");
            }
            else
            {
                Node current = Head;
                bool found = false;

                while (current != null)
                {

                    if (current.Data == value)
                    {
                        Node oldNext = current.Next;
                        current.Next = new Node(newValue);
                        current.Next.Next = oldNext;
                        if(current == Tail)
                        {
                            Tail = current.Next;
                        }

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
            Length += 1;

        }

        public int kthFromEnd(int k)
        {
            if(k < 0)
            {
                throw new ArgumentException($"{k} is not a valid input");
            }

            if(k > Length)
            {
                throw new ArgumentException($"The list is shorter than {k} length.");
            }

            Node currentNode = Head;

            for (int i = 0; i < (Length - 1) - k; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Data;
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
