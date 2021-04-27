using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");

            graph.AddEdge("A", "B");
            graph.AddEdge("B", "D");
            graph.AddEdge("D", "C");
            graph.AddEdge("A", "C");
            // graph.RemoveEdges("A", "C");
            // graph.RemoveEdges("A", "D");
            graph.Print();

            // graph.TraverseDepthFirstRec("C");
            //graph.TraverseDepthFirst("C");

            graph.TraverseBreathFirst("A");
        }

        
    }
}
