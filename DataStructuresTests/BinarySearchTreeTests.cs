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

        //[Fact]
        //public void CanAddMultipleNodes()
        //{
        //    BinarySearchTree binarySearchTree = new BinarySearchTree();

        //    binarySearchTree.Add(4);
        //    binarySearchTree.Add(2);

        //    Assert.Equal("[2, 4]", binarySearchTree.ToString());
        //}
    }
}
