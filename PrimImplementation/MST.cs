using System;
using System.Collections.Generic;
using System.Text;

namespace MST
{
    public static class MST
    {
        public static void Prim(Graph graph, Vertex start)
        {

            var q = new PriorityQueue<Vertex>(true);
            foreach (var v in graph.Vertices)
            {
                v.Key = int.MaxValue;
                v.Parent = null;
                q.Enqueue(v.Key, v);
            }
            start.Key = 0;
            int iteration = 0;
            graph.Print(iteration);
            while (q.Count != 0)
            {
                iteration++;
                var u = q.Dequeue();
                u.IsProcessed = true;
                int[] edges = graph.AdjacencyMatrix[u.Index];
                for (int v = 0; v < edges.Length; v++)
                {
                    var vertex = graph.Vertices[v];

                    var w = graph.AdjacencyMatrix[u.Index][v];

                    if (w > 0 && !vertex.IsProcessed && w < vertex.Key)
                    {
                        vertex.Parent = u;
                        vertex.Key = w;
                        q.UpdatePriority(vertex,vertex.Key);

                    }
                }
                graph.Print(iteration);

            }

        }
    }
}
