using System;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayShiftTests
    {
        [Fact]
        public void InsertIntoEvenLength()
        {
            //Arrange
            int[] input = new[] { 4, 5, 7, 8 };

            //Act
            int[] result = ArrayChallenges.InsertArrayShift(input, 6);

            // Assert
            Assert.Equal(new[] { 4, 5, 6, 7, 8}, result);
        }

        [Theory]
        // Check for zero
        [InlineData(1, new int[0], new[] { 1 })]
        [InlineData(2, new int[0], new[] { 2 })]

        // Check even
        [InlineData(3, new int[] { 2 }, new[] { 2, 3 })]

        // Check odd
        [InlineData(3, new int[] { 2, 4 }, new[] { 2, 3, 4})]


        public void InsertIntoArray(int value, int[] input, int[] expected)
        {
            // Arrange is above with InlineData

            // Act
            int[] result = ArrayChallenges.InsertArrayShift(input, value);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void InsertIntoOddLength()
        {
            // Arrange
            int[] input = new[] { 4, 5, 6, 8, 9 };

            //Act
            int[] result = ArrayChallenges.InsertArrayShift(input, 7);

            // Assert
            Assert.Equal(new[] { 4, 5, 6, 7, 8, 9 }, result);
        }
    }
}
