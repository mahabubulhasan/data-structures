using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class WeightedGraph
    {
        private Dictionary<string, Node> nodes = new();
        private Dictionary<Node, List<Edge>> adjacencyList = new();

        public void AddNode(string label)
        {
            if (!nodes.ContainsKey(label))
            {
                var node = new Node(label);
                nodes.Add(label, node);
                adjacencyList.Add(node, new());
            }
        }

        public void AddEdge(string from, string to, int weight)
        {
            var fromNode = nodes[from];
            var toNode = nodes[to];

            adjacencyList[fromNode].Add(new(fromNode, toNode, weight));
            adjacencyList[toNode].Add(new(toNode, fromNode, weight));
        }

        public void Print()
        {
            foreach (var source in adjacencyList)
            {
                var targets = adjacencyList[source.Key];
                if (targets.Any())
                {
                    Console.WriteLine($"{source.Key} is connected to {string.Join(',', targets)}");
                }
            }
        }

        private class Node
        {
            private readonly string label;

            public Node(string label)
            {
                this.label = label;
            }

            public override string ToString() => label;
        }

        private class Edge
        {
            private readonly Node from;
            private readonly Node to;
            private readonly int weight;

            public Edge(Node from, Node to, int weight)
            {
                this.from = from;
                this.to = to;
                this.weight = weight;
            }

            public override string ToString() => $"{from}->{to}";
        }
    }
}
