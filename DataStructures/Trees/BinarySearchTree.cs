using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{

    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public void Add(T value)
        {
            Node node = new Node();
            node.Value = value;

            if(Root == null)
            {
                Root = node;
            }
            else
            {
                Node current = Root;
                Node parentNode;

                while(true)
                {
                    parentNode = current;
                    if(value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        if(current == null)
                        {
                            parentNode.Left = node;
                            return; 
                        } 
                    }
                    current = current.Right;
                    if(current == null)
                    {
                        parentNode.Right = node;
                        return; 
                    }
                }
            }
        } 

        public bool Contains(Node root, T value)
        {
            while (root != null)
            {
                if (root.Value.Equals(value))
                {
                    return true; 
                }
                else if (root.Value.CompareTo(value) > 0)
                {
                    return Contains(root.Left, value); 
                }
                else
                {
                    return Contains(root.Right, value); 
                }
            }
            return false;
        }
 

        
    }
}
