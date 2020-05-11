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
    }
}
