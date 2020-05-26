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
    }
}
