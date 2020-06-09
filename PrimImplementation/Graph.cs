using System;
using System.Collections.Generic;
using System.Text;

namespace MST
{
    public class Graph
    {

        public List<Vertex> Vertices { get; private set; }

        public int[][]  AdjacencyMatrix { get; private set; }

        public Graph(int[][] adj)
        {
            int vertexCount = adj.GetLength(0);
            Vertices = new List<Vertex>();
            AdjacencyMatrix = adj;
            for (char i = 'A'; i < 'A'+vertexCount; i++)
            {
                Vertices.Add(new Vertex { Index=i-'A', Name = i.ToString() });
            }
        }

        internal void Print(int iteration)
        {
            Console.WriteLine("Iteration:" + iteration);
            foreach (var item in Vertices)
            {
                Console.WriteLine($"{item.Name}\t{item.Key}");
            }
            Console.WriteLine("---------------");

        }
    }
}
