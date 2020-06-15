using System;
using Xunit;

namespace Challenges.Tests
{
    public class RepeatedWordTests
    {
        [Fact]
        public void CanReturnRepeatedWordsTest()
        {

            string inputStr = "Once upon a time there was a brave princess who";

            string outputStr = RepeatedWord.FirstRepeating(inputStr);

            Assert.Equal("a", outputStr);
            
        }

    }
}
