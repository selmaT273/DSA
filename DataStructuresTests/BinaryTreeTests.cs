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
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);

            string preOrder = string.Join(", ", tree.PreOrder(tree.Root));

            Assert.Equal("1, 2, 4, 5, 3", preOrder);
        }

        [Fact]
        public void CanInOrderTest()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);

            string inOrder = string.Join(", ", tree.InOrder(tree.Root));

            Assert.Equal("4, 2, 5, 1, 3", inOrder);
        }

        [Fact]
        public void CanPostOrderTest()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);

            string postOrder = string.Join(", ", tree.PostOrder(tree.Root));

            Assert.Equal("4, 5, 2, 3, 1", postOrder);
        }

        [Fact]
        public void CanBreadthFirstTest()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);

            string breadthFirst = string.Join(", ", tree.BreadthFirst());

            Assert.Equal("1, 2, 3, 4, 5", breadthFirst);
        }
    }
}
