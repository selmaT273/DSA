using System;
using DataStructures.Queue;
using Xunit;

namespace DataStructuresTests
{
    public class QueueTests
    {
        [Fact]
        public void PeekEmptyQueueThrowsTest()
        {
            Queue<object> queue = new Queue<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                queue.Peek();
            });
        }

        [Fact]
        public void QueueIsEmptyReturnsTrueIfEmptyTest()
        {
            Queue<object> queue = new Queue<object>();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void CanEnqueueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);

            Assert.Equal(5, queue.Peek());


        }

        [Fact]
        public void CanEnqueueMultipleValuesTest()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(8);

            Assert.Equal(3, queue.Peek());
        }

        [Fact]
        public void CanDequeueOneTest()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(8);

            Assert.Equal(3, queue.Dequeue());
        }

        [Fact]
        public void CanDequeueUntilEmptyTest()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(8);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void DequeueEmptyStackThrowsTest()
        {
            Queue<object> queue = new Queue<object>();

            Assert.Throws<ArgumentException>(() =>
            {
                queue.Dequeue();
            });
        }
    }
}