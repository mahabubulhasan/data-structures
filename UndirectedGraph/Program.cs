﻿using System;

namespace UndirectedGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new WeightedGraph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddEdge("A", "B", 3);
            graph.AddEdge("A", "C", 2);

            graph.Print();
        }
    }
}
