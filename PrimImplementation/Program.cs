using System;
using System.Linq;
using System.Numerics;

namespace MST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MST PRim's Algorithm");

            var adj = new int[][] {
               new int[]{ 0,9,1,8,0,0,0,0},
               new int[]{ 9,0,2,2,0,0,9,0},
               new int[]{ 1,2,0,0,0,3,0,0},
               new int[]{ 8,2,0,0,0,0,0,0},
               new int[]{ 0,0,0,0,0,0,0,2},
               new int[]{ 0,0,3,0,0,0,0,3},
               new int[]{ 0,9,0,0,0,0,0,0},
               new int[]{ 0,0,0,0,2,3,0,0},
            };
            Graph g = new Graph(adj);
            MST.Prim(g, g.Vertices.First());
            int total = 0;
            foreach (var item in g.Vertices.Where(p=>p.Parent!=null))
            {
                total += item.Key;
                
                Console.WriteLine($"Vertex {item.Index} to Vertex {item.Parent.Index} weight is: {item.Key}");
            }
            Console.WriteLine($" MST Total Cost={total} ");


            Console.ReadKey();

        }
    }
}
