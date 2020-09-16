using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{

    public class BinarySearchTree<T> : BinaryTree<T>
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

        public bool Contains(int value)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Contains(Root, value);
            }
        }

        private bool Contains(Node node, int value)
        {
            if(node.Value == value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                if(node.Left == null)
                {
                    return false;
                }
                else
                {
                    return Contains(node.Left, value);
                    
                }
            }
            else
            {
                if(node.Right == null)
                {
                    return false;
                }
                else
                {
                    return Contains(node.Right, value);
                }
            }
        }

        
    }
}
