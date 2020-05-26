using System;
using DataStructures.Trees;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        public void Add(int addedNode)
        {
            if (addedNode <= DataStructures.Trees.BinaryTree)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.Add(addedNode);
                }
            }
        }
    }
}
