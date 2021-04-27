using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        private Dictionary<string, Node> nodes = new();
        private Dictionary<Node, List<Node>> adjacencyList = new();

        public void AddNode(string label)
        {
            var node = new Node(label);
            nodes.Add(label, node);
            adjacencyList.Add(node, new());
        }

        public void AddEdge(string from, string to)
        {
            if (!nodes.ContainsKey(from) || !nodes.ContainsKey(to))
            {
                throw new KeyNotFoundException();
            }

            adjacencyList[nodes[from]].Add(nodes[to]);
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

        public void RemoveNode(string label)
        {
            if (!nodes.ContainsKey(label)) return;

            var node = nodes[label];
            foreach (var n in adjacencyList)
            {
                n.Value.Remove(node);
            }

            adjacencyList.Remove(node);
            nodes.Remove(label);
        }


        public void RemoveEdges(string from, string to)
        {
            if (!nodes.ContainsKey(from) || !nodes.ContainsKey(to))
            {
                return;
            }

            var fromNode = nodes[from];
            var toNode = nodes[to];

            adjacencyList[fromNode].Remove(toNode);
        }

        public void TraverseBreathFirst(string root)
        {
            if (!nodes.ContainsKey(root)) return;

            var queue = new Queue<Node>();
            queue.Enqueue(nodes[root]);
            var visited = new HashSet<Node>();

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var item in adjacencyList[current])
                {
                    if (!visited.Contains(item))
                        queue.Enqueue(item);
                }
            }
        }

        public void TraverseDepthFirst(string root)
        {
            if (!nodes.ContainsKey(root)) return;

            var stack = new Stack<Node>();
            stack.Push(nodes[root]);
            var visited = new HashSet<Node>();

            while (stack.Any())
            {
                var current = stack.Pop();
                
                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var item in adjacencyList[current])
                {
                    if(!visited.Contains(item))
                        stack.Push(item);
                }
            }
        }

        public void TraverseDepthFirstRec(string root)
        {
            if (!nodes.ContainsKey(root)) return;

            TraverseDepthFirstRec(nodes[root], new());
        }

        private void TraverseDepthFirstRec(Node root, HashSet<Node> visited)
        {
            visited.Add(root);
            Console.WriteLine(root);

            foreach(var node in adjacencyList[root])
            {
                if(!visited.Contains(node))
                    TraverseDepthFirstRec(node, visited);
            }
        }

        private class Node
        {
            private string label;
            public Node(string label)
            {
                this.label = label;
            }

            public override string ToString()
            {
                return label;
            }
        }
    }
}
