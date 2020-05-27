using System;
using System.Collections.Generic;
using DataStructures.Trees;
using Xunit;

namespace DataStructuresTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void CanPreOrderTest()
        {
            BinaryTree tree = new BinaryTree();

            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            Assert.Equal("1, 2, 4, 5, 3", tree.ToString());
        }
    }
}
