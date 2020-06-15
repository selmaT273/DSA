using System;
using System.Collections.Generic;

namespace Challenges
{
    public class HashNode
    {
        private string key;
        private string value;
        public HashNode()
        {
            key = "";
            value = "";
        }
        public HashNode(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string GetKey()
        {
            return key;
        }

        public string GetValue()
        {
            return value;
        }

        public bool Contains(Object o)
        {
            HashNode other = (HashNode)o;
            return other.key == this.key;
        }
    }

    public class HashTable
    {
        private List<HashNode>[] hashList;
        private static int size = 1024;

        public HashTable()
        {
            hashList = new List<HashNode>[size];
            for (int i = 0; i < size; i++)
            {
                hashList[i] = new List<HashNode>();
            }
        }

        private int CreateHash(string s)
        {
            int hash = 0;
            for (int i = 0; i < s.Length; i++)
            {
                hash += s[i];
            }

            return (hash % size);
        }

        public string GetValue(string targetKey)
        {
            int hash = CreateHash(targetKey);
            List<HashNode> thisList = hashList[hash];
            foreach (HashNode n in thisList)
            {
                if (n.GetKey() == targetKey)
                {
                    return n.GetValue();
                }
            }

            return "";
        }

        public void Add(HashNode n)
        {
            int hash = CreateHash(n.GetKey());
            List<HashNode> thisList = hashList[hash];
            if (!thisList.Contains(n))
            {
                thisList.Add(n);
            }
        }
    }


}
