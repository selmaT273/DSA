using System;

namespace DataStructures.Trees
{

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

        
    }
}
