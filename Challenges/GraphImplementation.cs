using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Challenges
{

  

    // void AddEdge(Node node1, Node node2);

    // void AddEdge(Node node1, Node node2, int? weight = null); <-- can add weight in later


    // IEnumerable<Node> GetNeighbors(Node node) => node.Neighbors;


    // class Node { ... }

    

    public class Graph<T>
    {
        readonly List<Node> nodes = new List<Node>();

        public Node AddNode(T value)
        {
            var node = new Node { Value = value };
            nodes.Add(node);
            return node;
        }

        public IReadOnlyList<Node> GetNodes()
        {
            return nodes;
        }

        public int Size() => nodes.Count;

        public Edge AddEdge(Node node1, Node node2, int weight = 1)
        {
            var edge = new Edge(node1, node2, weight);
            node1.Edges.Add(edge);
            node2.Edges.Add(edge);
            return edge;
        }

        public class Node
        {
            public T Value { get; set; }
            public List<Edge> Edges { get; } = new List<Edge>();

        }

        public class Edge
        {
            public Node Node1 { get; private set; }

            public Node Node2 { get; private set; }

            public int Weight { get; set; }

            public Edge(Node node1, Node node2, int weight)
            {
                Node1 = node1;
                Node2 = node2;
                Weight = weight;
            }
        }
    }
}