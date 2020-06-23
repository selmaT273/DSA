using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Challenges
{

    // Node AddNode(T value);

    // void AddEdge(Node node1, Node node2);

    // void AddEdge(Node node1, Node node2, int? weight = null); <-- can add weight in later

    // IReadOnlyList<Node> GetNodes();

    // IEnumerable<Node> GetNeighbors(Node node) => node.Neighbors;

    // int Size();

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

        public class Node
        {
            public T Value { get; set; }


        }

        public IReadOnlyList<Node> GetNodes()
        {
            return nodes;
        }

        public int Size() => nodes.Count;
    }
}