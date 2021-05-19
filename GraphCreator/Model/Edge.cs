using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Model
{
    public class Edge
    {
        public Vertex StartVertex { get; set; }
        public Vertex EndVertex { get; set; }
        public bool HasDirection { get; set; }
        public int Weight { get; set; }
        public bool HasWeight { get; set; }
        public Style Style { get; private set; }
        public bool IsLocked { get; set; }
        public Edge(Vertex start, Vertex end)
        {
            StartVertex = start;
            EndVertex = end;
            HasDirection = false;
            Weight = 0;
            HasWeight = false;
            Style = new Style();
        }
        public void ReverseDirection()
        {
            var buff = StartVertex;
            StartVertex = EndVertex;
            EndVertex = buff;
        }

        public bool ContainVertexPair(Edge edge)
        {
            return ContainVertexPair(edge.StartVertex, edge.EndVertex);
        }

        public bool ContainVertexPair(Vertex firstVertex, Vertex secondVertex)
        {
            return (StartVertex == secondVertex && EndVertex == firstVertex) || (EndVertex == secondVertex && StartVertex == firstVertex);
        }

        public bool ContainVertex(Vertex vertex) => StartVertex == vertex || EndVertex == vertex;

        public Vertex GetOppositeVertex(Vertex vertex) => vertex == StartVertex ? EndVertex : StartVertex;

        public override string ToString()
        {
            return string.Format("{0}-{1}", StartVertex.Index, EndVertex.Index);
        }
    }
}
