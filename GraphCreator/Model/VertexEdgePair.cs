using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Model
{
    class VertexEdgePair
    {
        public Vertex Vertex { get; set; }

        public Edge Edge { get; set; }

        public VertexEdgePair()
        {

        }

        public VertexEdgePair(Vertex vertex, Edge edge)
        {
            Vertex = vertex;
            Edge = edge;
        }
    }
}
