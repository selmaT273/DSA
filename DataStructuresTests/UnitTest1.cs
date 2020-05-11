using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateEmptyListTest()
        {
            LinkedList list = new LinkedList();

            Assert.Equal("", list.ToString());
        }

        [Fact]
        public void InsertAtHeadTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);

            Assert.Equal("1", list.ToString());
        }

        [Fact]
        public void HeadPointsAtFirstNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);

            Assert.Equal("5", list.Head.ToString());
        }

        [Fact]
        public void InsertMultipleNodesTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(6);

            Assert.Equal("6 4", list.ToString());
        }

    }
}
