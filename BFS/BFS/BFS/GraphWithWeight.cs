using System;
using System.Collections.Generic;
namespace BFS
{
    public class GraphWithWeight
    {
        private int V;

        private List<(int, int)>[] adj;

        public GraphWithWeight(int v) 
        {
            V = v;
            adj = new List<(int,int)>[v];

            for(int i = 0; i < v; i++)
            {
                adj[i] = new List<(int adjvertex, int weight)>();
            }
        }

        public void AddEdge(int v, int w, int weight)
        {
            adj[v].Add((w,weight));
        }

        public void BFS(int startVertex)
        {
            bool[] visited = new bool[V];

            Queue<int> vqueue = new Queue<int>();

            visited[startVertex] = true;
            vqueue.Enqueue(startVertex);

            while(vqueue.Count != 0)
            {
                startVertex = vqueue.Dequeue();
                Console.Write(startVertex + " ");

                foreach((int, int) neighbor in adj[startVertex])
                {
                    if (!visited[neighbor.Item1])
                    {
                        visited[neighbor.Item1] = true;
                        vqueue.Enqueue(neighbor.Item1);
                    }
                }
            }
        }
    }
}
