using System;
using Xunit;

namespace Challenges.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void CanImplementQuickSortTest()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };

            int[] result = QuickSort.QuickSorting(testArray, 0, testArray.Length - 1);

            Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, result);
        }
    }
}
