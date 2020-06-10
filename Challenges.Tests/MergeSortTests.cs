using System;
using Xunit;

namespace Challenges.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void CanImplementMergeSortTest()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };

            int[] result = MergeSort.MergeSorting(testArray);

            Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, result);
        }
    }
}
