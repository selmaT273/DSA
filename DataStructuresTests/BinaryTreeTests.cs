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

            string preOrder = string.Join(", ", tree.PreOrder(tree.Root, new Queue<int>()));

            Assert.Equal("1, 2, 4, 5, 3", preOrder);
        }

        [Fact]
        public void CanInOrderTest()
        {
            BinaryTree tree = new BinaryTree();

            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            string inOrder = string.Join(", ", tree.InOrder(tree.Root, new Queue<int>()));

            Assert.Equal("4, 2, 5, 1, 3", inOrder);
        }

        [Fact]
        public void CanPostOrderTest()
        {
            BinaryTree tree = new BinaryTree();

            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            string postOrder = string.Join(", ", tree.PostOrder(tree.Root, new Queue<int>()));

            Assert.Equal("4, 5, 2, 3, 1", postOrder);
        }
    }
}
