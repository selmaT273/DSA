﻿using System;
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

        [Fact]
        public void CanPushToStackTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(5);

            Assert.Equal(5, stack.Peek());
            
            
        }

        [Fact]
        public void CanPushMultipleValuesTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.Equal(8, stack.Peek());
        }

        [Fact]
        public void CanPopOneTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.Equal(8, stack.Pop());
        }

        [Fact]
        public void CanPopUntilEmptyTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void PopEmptyStackThrowsTest()
        {
            Stack<object> stack = new Stack<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                stack.Pop();
            });
        }
    }
}
