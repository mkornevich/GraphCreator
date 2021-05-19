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
    class PrimSpanningTree : BaseAlgorithm
    {
        public PrimSpanningTree()
        {
            Name = "Остовное дерево Прима";
            Description = "Данный алгоритм находит минимальное остовное дерево по алгоритму Прима.";
        }

        public override void Run()
        {
            if (!GraphHelper.IsGraphWeighted(Project))
            {
                IO.WriteLn("Глаф обязательно должен быть взвешанным");
                return;
            }

            var selectedVertexes = new List<Vertex>();
            var spanningEdges = new List<Edge>();

            var startVertex = IO.ReadLnExistVerex("Введите произвольную стартовую вершину графа:");

            selectedVertexes.Add(startVertex);

            VertexEdgePair minNonCycledPair;
            while ((minNonCycledPair = GetMinNonCycledPairByVertexes(selectedVertexes)) != null)
            {
                spanningEdges.Add(minNonCycledPair.Edge);
                selectedVertexes.Add(minNonCycledPair.Vertex);
            }

            foreach (var sEdge in spanningEdges)
            {
                sEdge.Style.LineWidth = 2;
                sEdge.Style.LineColor = Color.Black;
            }

            IO.WriteLn("Готово!");

        }

        private VertexEdgePair GetMinNonCycledPairByVertexes(List<Vertex> selectedVertexes)
        {
            var linkedVertexEdges = new List<VertexEdgePair>();

            foreach (var parrentVertex in selectedVertexes)
                foreach (var edge in Project.Edges)
                    if (edge.ContainVertex(parrentVertex) && !linkedVertexEdges.Exists(pair => pair.Edge == edge))
                    {
                        var linkedVertex = edge.StartVertex == parrentVertex ? edge.EndVertex : edge.StartVertex;
                        linkedVertexEdges.Add(new VertexEdgePair(linkedVertex, edge));
                    }

            if (linkedVertexEdges.Count == 0) return null;

            linkedVertexEdges = linkedVertexEdges.OrderBy(pair => pair.Edge.Weight).ToList();

            return linkedVertexEdges.Find(pair => !selectedVertexes.Exists(vertex => vertex == pair.Vertex));
        }
    }
}
