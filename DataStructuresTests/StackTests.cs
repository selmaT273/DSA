using System;
using DataStructures;
using Xunit;

namespace DataStructuresTests
{
    public class StackTests
    {
        [Fact]
        public void PeekEmptyStackThrows()
        {
            Stack<object> stack = new Stack<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                stack.Peek();
            });
        }
    }
}
