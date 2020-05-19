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


        [Fact]
        public void PeekEmptyPseudoQueueThrowsTest()
        {
            PseudoQueue<object> pseudoQueue = new PseudoQueue<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                pseudoQueue.Peek();
            });
        }



        [Fact]
        public void PseudoEnqueueMultipleValuesTest()
        {
            PseudoQueue<int> pseudo1 = new PseudoQueue<int>();

            pseudo1.Enqueue(3);
            pseudo1.Enqueue(5);
            pseudo1.Enqueue(8);

            Assert.Equal(3, pseudo1.Peek());
        }

        [Fact]
        public void CanPseudoDequeueOneTest()
        {
            PseudoQueue<int> pseudo1 = new PseudoQueue<int>();

            pseudo1.Enqueue(3);
            pseudo1.Enqueue(5);
            pseudo1.Enqueue(8);

            Assert.Equal(3, pseudo1.Dequeue());
        }


        [Fact]
        public void DequeueEmptyStackThrowsTest()
        {
            PseudoQueue<object> pseudo1 = new PseudoQueue<object>();

            Assert.Throws<Exception>(() =>
            {
                pseudo1.Dequeue();
            });
        }
    }
}
