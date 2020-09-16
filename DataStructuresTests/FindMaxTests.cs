using System;
using DataStructures.Queue;
using DataStructures.Stack;
using DataStructures.Trees;
using Xunit;

namespace DataStructuresTests
{
    public class FindMaxTests
    {
        [Fact]
        public void CanFindMaxTest()
        {
            FindMax<int> tree = new FindMax<int>();
            tree.Root = new Node(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Left.Right.Left = new Node(1);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Right.Right.Left = new Node(4);

            
            Assert.Equal(11, tree.FindMaxValue(tree.Root));
        }
    }
}
