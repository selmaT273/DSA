using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
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

        public Queue<int> PostOrder(Node node, Queue<int> queue)
        {
            if (node == null)
            {
                return queue;
            }
            else
            {
                PostOrder(node.Left, queue);
                PostOrder(node.Right, queue);
                queue.Enqueue(node.Value);

                return queue;
            }
        }


        public override string ToString()
        {
            return string.Join(", ", PreOrder(Root, new Queue<int>()));
        }

       public Queue<int> BreadthFirst()
        {
            Queue<int> result = new Queue<int>();
            if(Root == null)
            {
                return result;
            }

            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(Root);

            while (nodes.Count != 0)
            {
                Node node = nodes.Dequeue();
                result.Enqueue(node.Value);
                if(node.Left != null)
                {
                    nodes.Enqueue(node.Left);
                }
                if(node.Right != null)
                {
                    nodes.Enqueue(node.Right);
                }
            }
            return result;
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