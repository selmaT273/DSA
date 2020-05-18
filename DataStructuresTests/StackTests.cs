using System;
using DataStructures.Stack;
using Xunit;

namespace DataStructuresTests
{
    public class StackTests
    {
        [Fact]
        public void PeekEmptyStackThrowsTest()
        {
            Stack<object> stack = new Stack<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                stack.Peek();
            });
        }

        [Fact]
        public void IsEmptyReturnsTrueIfEmptyTest()
        {
            Stack<object> stack = new Stack<object>();

            Assert.True(stack.IsEmpty());
        }
    }
}
