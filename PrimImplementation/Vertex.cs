using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MST
{
    public class Vertex:IComparable<Vertex>
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public Vertex Parent { get; set; }

        public bool IsProcessed { get; set; }
        public override string ToString()
        {
            return $"{Index}-{Name}({Key})";
        }

        public int CompareTo([AllowNull] Vertex other)
        {
            if (other == null)
                return 1;
            if (Key == other.Key)
                return 0;
            if (Key < other.Key)
                return 1;

            return -1;

        }

     
        public int Key { get; set; }
    }
}
