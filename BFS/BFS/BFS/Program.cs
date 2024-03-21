using BFS;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        GraphWithWeight graphWithWeight = new GraphWithWeight(5);
        graphWithWeight.AddEdge(0, 1, 2);
        graphWithWeight.AddEdge(0, 2, 2);
        graphWithWeight.AddEdge(1, 2, 2);
        graphWithWeight.AddEdge(2, 0, 2);
        graphWithWeight.AddEdge(2, 3, 2);
        graphWithWeight.AddEdge(3, 3, 2);

        graphWithWeight.BFS(2);

    }
}
