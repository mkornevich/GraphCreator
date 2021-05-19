using GraphCreator.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm.SimpleAlgorithms
{
    class IncidenceMatrix : BaseAlgorithm
    {
        public IncidenceMatrix()
        {
            Name = "Матрица инцидентности";
            Description = "Данный алгоритм выполняет построение матрицы инцидентности.";
        }
        public override void Run()
        {
            IO.WriteLn("Матрица инцидентности текущего графа:");

            var edges = Project.Edges;
            var vertexes = Project.Vertexes;

            var grid = new StringGrid(edges.Count + 1, vertexes.Count + 1);

            for (int col = 1; col < edges.Count + 1; col++)
                grid[0, col] = edges[col - 1].ToString();

            for (int row = 1; row < vertexes.Count + 1; row++)
                grid[row, 0] = vertexes[row - 1].ToString();

            for (int iEdge = 0; iEdge < edges.Count; iEdge++)
                for (int iVertex = 0; iVertex < vertexes.Count; iVertex++)
                {
                    var edge = edges[iEdge];
                    var vertex = vertexes[iVertex];

                    string cell = "0";
                    if (!edge.HasDirection && (edge.StartVertex == vertex || edge.EndVertex == vertex)) cell = "1";
                    if (edge.HasDirection && edge.EndVertex == vertex) cell = "-1";
                    if (edge.HasDirection && edge.StartVertex == vertex) cell = "1";

                    grid[iVertex + 1, iEdge + 1] = cell;
                }
            IO.Write(grid);
        }
    }
}
