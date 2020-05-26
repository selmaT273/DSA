using System;

namespace DataStructures.Trees
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
        }

        public override string ToString()
        {
            if (Root == null)
            {
                return "[]";
            }
            else
            {
                string output = stringBuilder(Root, "");
                return "[" + output + "]";
            }

        }
        public string stringBuilder(Node node, string output)
        {
            if (node != null)
            {
                stringBuilder(node.Left, output);
                output += ", " + node;
                stringBuilder(node.Right, output);
            }
            return output;
        }
    }
}
