using System;
using Xunit;

namespace Challenges.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void ReturnsIndexOfValueTest()
        {
            //Arrange
            int[] input = new[] { 4, 5, 7, 8, 9};
            int searchKey = 5;

            //Act
            int result = ArrayChallenges.BinarySearch(input, searchKey);

            // Assert
            Assert.Equal(1, result);
        }

        // Test if input array is empty

        // Test if there's more than one searchKey value

        // Test if there's an even # of elements

        // Test returns -1 if searchKey doesnt exist in inputArray
    }
}
