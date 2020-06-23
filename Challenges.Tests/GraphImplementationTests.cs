using System;
using Challenges;
using Xunit;

namespace Challenges.Tests
{
    public class GraphImplementationTests
    {
        [Fact]
        public void GraphStartsEmptyTest()
        {
            var graph = new Graph<int>();

            Assert.Empty(graph.GetNodes());
            Assert.Equal(0, graph.Size());
        }

        [Fact]
        public void CanAddNodeTest()
        {
            var graph = new Graph<int>();

            var node = graph.AddNode(4);

            Assert.NotNull(node);
            Assert.Equal(4, node.Value);
            Assert.Contains(node, graph.GetNodes());
            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void CanAddEdgeTest()
        {
            var graph = new Graph<int>();

            var node1 = graph.AddNode(4);
            var node2 = graph.AddNode(6);

            var edge = graph.AddEdge(node1, node2);

            Assert.Contains(edge, node1.Edges);
        }
    }
}
