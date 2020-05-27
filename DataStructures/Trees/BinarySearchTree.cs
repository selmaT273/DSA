using System;

namespace DataStructures.Trees
{

    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            if(Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }
        }

        private void Add(Node node, int value)
        { 
            if (node == null)
            {
                node = new Node(value);
            }
            else
            {
                if(value < node.Value)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node(value);
                    }
                    else
                    {
                        Add(node.Left, value);
                    }
                }
                else
                {
                    if(node.Right == null)
                    {
                        node.Right = new Node(value);
                    }
                    else
                    {
                        Add(node.Right, value);
                    }
                }
            }
        }

        
    }
}
