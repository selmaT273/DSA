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

    //[Fact]
    //public void PeekEmptyQueueThrowsTest()
    //{
    //    PseudoQueue<object> queue = new PseudoQueue<object>();

    //    Assert.Throws<ArgumentException>(() =>
    //    {
    //        queue.Peek();
    //    });
    //}

    

    //[Fact]
    //public void PseudoEnqueueMultipleValuesTest()
    //{
    //    PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

    //    pseudoQueue.Enqueue(3);
    //    pseudoQueue.Enqueue(5);
    //    pseudoQueue.Enqueue(8);

    //    Assert.Equal(3, pseudoQueue.Peek());
    //}

    //[Fact]
    //public void CanDequeueOneTest()
    //{
    //    Queue<int> queue = new Queue<int>();

    //    queue.Enqueue(3);
    //    queue.Enqueue(5);
    //    queue.Enqueue(8);

    //    Assert.Equal(3, queue.Dequeue());
    //}

    //[Fact]
    //public void CanDequeueUntilEmptyTest()
    //{
    //    Queue<int> queue = new Queue<int>();

    //    queue.Enqueue(3);
    //    queue.Enqueue(5);
    //    queue.Enqueue(8);

    //    queue.Dequeue();
    //    queue.Dequeue();
    //    queue.Dequeue();

    //    Assert.True(queue.IsEmpty());
    //}

    //[Fact]
    //public void DequeueEmptyStackThrowsTest()
    //{
    //    Queue<object> queue = new Queue<object>();

    //    Assert.Throws<ArgumentException>(() =>
    //    {
    //        queue.Dequeue();
    //    });
    //}
}
