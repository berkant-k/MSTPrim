using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MST
{
    public class VertexComparer : IComparer<Vertex>
    {
        public int Compare([AllowNull] Vertex x, [AllowNull] Vertex y)
        {
            return x.CompareTo(y);
        }
    }
}
