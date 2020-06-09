using System;
using Xunit;
using Challenges;
using System.Linq;

namespace Challenges.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void CanImplementInsertionSortTest()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };

            int[] result = InsertionSort.InsertionSorting(testArray);

            Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, result);
        }
    }
}
