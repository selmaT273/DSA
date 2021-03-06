using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiateEmptyListTest()
        {
            LinkedList list = new LinkedList();

            Assert.Equal("", list.ToString());
            Assert.Equal(0, list.Length);
        }

        [Fact]
        public void InsertAtHeadTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);

            Assert.Equal("{ 1 } -> NULL", list.ToString());
            Assert.Equal(1, list.Length);
        }

        [Fact]
        public void HeadPointsAtFirstNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);

            Assert.Equal("5", list.Head.ToString());
            Assert.Equal(1, list.Length);
        }

        [Fact]
        public void InsertMultipleNodesTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(6);

            Assert.Equal("{ 6 } -> { 4 } -> NULL", list.ToString());
            Assert.Equal(2, list.Length);
        }

        [Fact]
        public void ReturnsTrueIfExistsTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(7);
            list.Insert(8);

            Assert.True(list.Includes(8));
            Assert.Equal(2, list.Length);
        }

        [Fact]
        public void ReturnsFalseIfDoesntExistTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(7);
            list.Insert(9);

            Assert.False(list.Includes(8));
            Assert.Equal(2, list.Length);
        }

        [Fact]
        public void ReturnsStringofAllValuesTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(3);
            list.Insert(6);

            Assert.Equal("{ 6 } -> { 3 } -> NULL", list.ToString());
            Assert.Equal(2, list.Length);

        }

        [Fact]
        public void TailPointsAtLastNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(5);
            list.Insert(6);

            Assert.Equal("5", list.Tail.ToString());
            Assert.Equal(2, list.Length);

        }

        [Fact]
        public void AppendAddsAtEndTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(2);
            list.Insert(6);
            list.Append(5);

            Assert.Equal("5", list.Tail.ToString());
            Assert.Equal(3, list.Length);

        }

        [Fact]
        public void AppendsMultipleNodesTest()
        {
            LinkedList list = new LinkedList();

            list.Append(4);
            list.Append(8);
            list.Append(9);

            Assert.Equal("9", list.Tail.ToString());
            Assert.Equal(3, list.Length);

        }

        [Fact]
        public void InsertNodeBeforeFirstNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.InsertBefore(3, 5);

            Assert.Equal("5", list.Head.ToString());
            Assert.Equal(4, list.Length);

        }

        [Fact]
        public void InsertNodeBeforeMiddleNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.InsertBefore(2, 5);

            Assert.Equal("{ 3 } -> { 5 } -> { 2 } -> { 1 } -> NULL", list.ToString());
            Assert.Equal(4, list.Length);

        }


        [Fact]
        public void InsertNodeAfterMiddleNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.InsertAfter(5, 3);

            Assert.Equal("{ 6 } -> { 5 } -> { 3 } -> { 4 } -> NULL", list.ToString());
            Assert.Equal(4, list.Length);

        }

        [Fact]
        public void InsertNodeAfterLastNodeTest()
        {
            LinkedList list = new LinkedList();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.InsertAfter(3, 5);

            Assert.Equal("5", list.Tail.ToString());
            Assert.Equal(4, list.Length);

        }

        [Fact]
        public void KReturnsCorrectValueTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Assert.Equal(3, list.kthFromEnd(2));
        }

        [Fact]
        public void KThrowsIfGreatherThanLengthTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Action action = () => list.kthFromEnd(5);

            ArgumentException exception = Assert.Throws<ArgumentException>(action);
            Assert.Equal("The list is shorter than 5 length.", exception.Message);
        }

        [Fact]
        public void KAndLengthAreSameTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Assert.Equal(4, list.kthFromEnd(4));
        }

        [Fact]
        public void KIsNegativeTest()
        {
            LinkedList list = new LinkedList();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Action action = () => list.kthFromEnd(-2);

            ArgumentException exception = Assert.Throws<ArgumentException>(action);
            Assert.Equal("-2 is not a valid input", exception.Message);
        }

        [Fact]
        public void LengthIs1Test()
        {
            LinkedList list = new LinkedList();

            list.Insert(2);


            Assert.Equal(2, list.kthFromEnd(0));
        }

    }
}
