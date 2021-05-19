using GraphCreator.Helper;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm.SimpleAlgorithms
{
    class KruskalSpanningTree : BaseAlgorithm
    {
        public KruskalSpanningTree()
        {
            Name = "Остовное дерево Краскала";
            Description = "Данный алгоритм находит минимальное остовное дерево по алгоритму Краскала.";
        }
        public override void Run()
        {
            if (!GraphHelper.IsGraphWeighted(Project))
            {
                IO.WriteLn("Глаф обязательно должен быть взвешанным");
                return;
            }

            var orderedEdges = Project.Edges.OrderBy(e => e.Weight);
            var spanningEdges = new List<Edge>();

            var segments = new List<List<Vertex>>();


            foreach (var edge in orderedEdges)
            {
                var segStart = segments.Find(s => s.Contains(edge.StartVertex));
                var segEnd = segments.Find(s => s.Contains(edge.EndVertex));

                if (segStart == null && segEnd == null)
                {
                    var newSeg = new List<Vertex>();
                    newSeg.Add(edge.StartVertex);
                    newSeg.Add(edge.EndVertex);
                    segments.Add(newSeg);
                    spanningEdges.Add(edge);
                }

                if (segStart == null && segEnd != null)
                {
                    segEnd.Add(edge.StartVertex);
                    spanningEdges.Add(edge);
                }

                if (segStart != null && segEnd == null)
                {
                    segStart.Add(edge.EndVertex);
                    spanningEdges.Add(edge);
                }

                if (segStart != null && segEnd != null && segStart != segEnd)
                {
                    segStart.AddRange(segEnd);
                    segments.Remove(segEnd);
                    spanningEdges.Add(edge);
                }

            }

            foreach (var sEdge in spanningEdges)
            {
                sEdge.Style.LineWidth = 2;
                sEdge.Style.LineColor = Color.Black;
            }


            IO.WriteLn("Минимальное остовное дерево успешно построено.");

        }
    }
}
