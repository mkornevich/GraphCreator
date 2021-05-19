using GraphCreator.Model;
using GraphCreator.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm.SimpleAlgorithms
{
    class ReachableMatrix : BaseAlgorithm
    {
        List<Vertex> vertexes;
        int len;

        public ReachableMatrix()
        {
            Name = "Матрица достижимости";
            Description = "Данный алгоритм позволяет найти матрицу достижимости.";
        }
        public override void Run()
        {
            vertexes = Project.Vertexes
                .OrderBy(v => v.Index)
                .ToList();
            len = vertexes.Count;

            // матрица смежности
            int[,] A = BuildAdjacencyMatrix();
            IO.WriteLn("=== Матрица смежности ===");
            PrintMatrix(A);

            // матрица достижимости
            int[,] R = new int[len, len];

            // инициализация матрицы достижимости
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    R[i, j] = (A[i, j] != 0 || i == j) ? 1 : 0;

            IO.WriteLn("=== Матрица достижимости инициализация ===");
            PrintMatrix(R);

            // просчет альтернативных путей прохода
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    for (int k = 0; k < len; k++)
                        if (R[i, j] == 0)
                            R[i, j] = (R[i, k] == 1 && R[k, j] == 1) ? 1 : 0;


            IO.WriteLn("=== Матрица достижимости ===");
            PrintMatrix(R);

        }

        private void PrintMatrix(int[,] matrix)
        {
            var stringGrid = BuildStringGridWithVertexHeaders();

            for (int row = 1; row <= len; row++)
                for (int col = 1; col <= len; col++)
                    stringGrid[row, col] = matrix[row - 1, col - 1].ToString();

            IO.WriteLn(stringGrid);
        }

        private int[,] BuildAdjacencyMatrix()
        {
            int[,] matrix = new int[len, len];

            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                {
                    // выбираем либо только направленное через которые можно проити от вершины либо ненаправленные
                    var edge = Project.Edges.Find(e =>
                        (e.HasDirection && e.StartVertex == vertexes[i] && e.EndVertex == vertexes[j]) ||
                        (!e.HasDirection && e.ContainVertexPair(vertexes[i], vertexes[j]))
                    );

                    matrix[i, j] = edge == null ? 0 : 1;
                }
            return matrix;
        }

        private StringGrid BuildStringGridWithVertexHeaders()
        {
            var stringGrid = new StringGrid(len + 1, len + 1);

            for (int col = 1; col <= len; col++)
                stringGrid[0, col] = vertexes[col - 1].Index.ToString();

            for (int row = 1; row <= len; row++)
                stringGrid[row, 0] = vertexes[row - 1].Index.ToString();

            return stringGrid;
        }
    }
}
