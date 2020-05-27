using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public Queue<int> PreOrder(Node node, Queue<int> queue)
        {
            if (node == null)
            {
                return queue;
            }
            else
            {
                queue.Enqueue(node.Value);
                PreOrder(node.Left, queue);
                PreOrder(node.Right, queue);

                return queue;
            }
            
        }

        public Queue<int> InOrder(Node node, Queue<int> queue)
        {
            if (node == null)
            {
                return queue;
            }
            else
            {
                InOrder(node.Left, queue);
                queue.Enqueue(node.Value);
                InOrder(node.Right, queue);

                return queue;
            }
        }


        public override string ToString()
        {
            return string.Join(", ", PreOrder(Root, new Queue<int>()));
        }
    }

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

    }
}