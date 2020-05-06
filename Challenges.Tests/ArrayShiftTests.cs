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

        //[Fact]
        //public void InsertIntoArray()
        //{

        //}

        //[Fact]
        //public void 
    }
}
