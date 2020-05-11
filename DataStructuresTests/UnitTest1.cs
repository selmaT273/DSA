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
    }
}
