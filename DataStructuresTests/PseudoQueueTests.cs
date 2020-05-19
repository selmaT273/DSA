using System;
using DataStructures;
using DataStructures.Stack;
using Xunit;

namespace DataStructuresTests
{
    public class PseudoQueueTests
    {
        [Fact]
        public void CanEnqueueTest()
        {
            PseudoQueue<int> pseudo1 = new PseudoQueue<int>();
            pseudo1.Enqueue(5);

            Assert.Equal(5, pseudo1.Peek());
        }
    }
}
