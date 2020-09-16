using System;

namespace DataStructures.Trees
{
    public class FindMax<T> : BinaryTree<T>
    {
        public Node root;

        public int FindMaxValue(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int tempMax = node.Value;
            int leftMax = FindMaxValue(node.Left);
            int rightMax = FindMaxValue(node.Right);

            if(leftMax > tempMax)
            {
                tempMax = leftMax;
            }
            if(rightMax > tempMax)
            {
                tempMax = rightMax;
            }

            return tempMax;
        }
    }
}
