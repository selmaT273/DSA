using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{

    public class HashTable
    {

        public int CreateHash(string key)
        {
            int index;
            byte[] totalBytes = Encoding.ASCII.GetBytes(key);
            int numberOfLetters = 0;
            for (int i = 0; i < totalBytes.Length; i++)
            {
                numberOfLetters += totalBytes[i];
            }

            index = (numberOfLetters * 599) % 1024;
            return index;
        }

        public int Size { get; set; }

        public HashNode[] NodeArray { get; set; }

        public HashTable(int size)
        {
            Size = size;
            NodeArray = new HashNode[size];
        }

        public string GetValue(string key)
        {
            int index = CreateHash(key);
            if(NodeArray[index] == null)
            {
                return null; 
            }

            if(NodeArray != null)
            {
                if(NodeArray[index].Key == key)
                {
                    return NodeArray[index].Value;
                }
                else
                {
                    HashNode current = NodeArray[index];
                    while(current.Next != null)
                    {
                        current = current.Next;
                        if(current.Key == key)
                        {
                            return current.Value;
                        }
                    }
                }
            }

            return null;
        }

        public bool Contains(string key)
        {
            int index = CreateHash(key);
            if (NodeArray[index] == null)
            {
                return false;
            }
            else
            {
                HashNode current = NodeArray[index];
                if(NodeArray[index].Key == key)
                {
                    return true;
                }
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Key == key)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void Add(string key, string value)
        {
            int index = CreateHash(key);
            if (NodeArray[index] == null)
            {
                HashNode newHashNode = new HashNode(key, value);
                NodeArray[index] = newHashNode;
            }
            else
            {
                HashNode newHashNode = new HashNode(key, value);
                HashNode current = NodeArray[index];
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHashNode;
            }
        }

        public class HashNode
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public HashNode Next { get; set; }

            public HashNode(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }

        }
    }


}
