using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class FindMax<T> : BinaryTree<T> where T : IComparable<T>
    {
        public Node root;

        public IEnumerable<T> FindMaxValue(Node node)
        {
            if (node == null)
            {
                throw new Exception("root is null");
            }

            T tempMax = node.Value;
            T leftMax = (T)FindMaxValue(node.Left);
            T rightMax = (T)FindMaxValue(node.Right);

            if(leftMax.CompareTo(tempMax) > 0)
            {
                tempMax = leftMax;
            }
            if(rightMax.CompareTo(tempMax) > 0)
            {
                tempMax = rightMax;
            }

            yield return tempMax;
        }
    }
}
