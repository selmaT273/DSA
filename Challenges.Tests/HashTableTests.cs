using System;
using Xunit;

namespace Challenges.Tests
{
    public class HashTableTests
    {
        [Fact]
        public void CanAddValueTest()
        {
            HashTable h = new HashTable(3);

            h.Add("stacey", "stacey teltser");

            Assert.True(h.Contains("stacey"));
        }
    }
}
