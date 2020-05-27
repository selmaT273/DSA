using System;
using Xunit;
using DataStructures.Trees;

namespace DataStructuresTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void InitializeEmptyTreeTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            Assert.Null(binarySearchTree.Root);
        }

        [Fact]
        public void CreateRootNodeIfNullTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Add(5);

            Assert.Equal(5, binarySearchTree.Root.Value);
        }

        [Fact]
        public void CanAddMultipleNodesTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Add(4);
            binarySearchTree.Add(2);

            Assert.Equal("4, 2", binarySearchTree.ToString());
        }

        [Fact]
        public void ContainsValueTest()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Add(4);
            binarySearchTree.Add(2);

            Assert.True(binarySearchTree.Contains(4));
            Assert.False(binarySearchTree.Contains(5));
        }
    }
}
