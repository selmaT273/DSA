using System;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayReverseTests
    {
        [Theory]
        [InlineData(new[] { 3, 5, 7, 2 }, new[] { 2, 7, 5, 3 })]

        public void can_reverse_array(int[] input, int[] expected)
        {

            int[] result = ArrayChallenges.ArrayReversed(input);
            Assert.Equal(expected, result);
        }
    }
}
