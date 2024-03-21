using System;
using System.Collections.Generic;
namespace BFS
{
    public class Graph
    {
        private int V;

        private List<int>[] adj;

        public Graph(int v) 
        {
            V = v;
            adj = new List<int>[v];

            for(int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
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

                foreach(int neighbor in adj[startVertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        vqueue.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
