using GraphCreator.Helper;
using GraphCreator.Model;
using GraphCreator.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm.SimpleAlgorithms
{
    class FloydWarshalAlgorithm : BaseAlgorithm
    {
        List<Vertex> vertexes;
        int len;

        public FloydWarshalAlgorithm()
        {
            Name = "Алгоритм Флойда";
            Description = "Данный алгоритм позволяет получить матрицу путей и матрицу минимальных весов.";
        }

        public override void Run()
        {
            if (!GraphHelper.IsGraphWeighted(Project))
            {
                IO.WriteLn("Граф должен быть взвешанный!");
                return;
            }

            vertexes = Project.Vertexes
                .OrderBy(v => v.Index)
                .ToList();
            len = vertexes.Count;

            var W = BuildWMatrix();
            var H = BuildHMatrix();

            IO.WriteLn("=== Начальная матрица весов ===");
            PrintWMatrix(W);
            IO.WriteLn();

            IO.WriteLn("=== Начальная матрица истории ===");
            PrintHMatrix(H);
            IO.WriteLn();

            IO.WriteLn("=== Выполнение алгоритма ===");

            //for (int i = 0; i < len; i++)
            //    for (int j = 0; j < len; j++)
            //        for(int k = 0; k < len; k++)
            //            if (W[i, j] > W[i, k] + W[k, j] && i != j && j != k && k != i)
            //            {
            //                W[i, j] = W[i, k] + W[k, j];
            //                H[i, j] = k;
            //            }


            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    if (W[i, j] != double.PositiveInfinity)
                        for (int k = 0; k < len; k++)
                            if (W[i, k] > W[i, j] + W[j, k])
                            {
                                W[i, k] = W[i, j] + W[j, k];
                                H[i, k] = H[i, j];
                            }

            IO.WriteLn("=== Алгоритм выполнен ===");
            IO.WriteLn();

            IO.WriteLn("=== Результирующая матрица весов ===");
            PrintWMatrix(W);
            IO.WriteLn();

            IO.WriteLn("=== Результирующая матрица истории ===");
            PrintHMatrix(H);
            IO.WriteLn();
        }

        private double[,] BuildHMatrix()
        {
            double[,] matrix = new double[len, len];

            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                {
                    // выбираем либо только направленное через которые можно проити от вершины либо ненаправленные
                    var edge = Project.Edges.Find(e =>
                        (e.HasDirection && e.StartVertex == vertexes[i] && e.EndVertex == vertexes[j]) ||
                        (!e.HasDirection && e.ContainVertexPair(vertexes[i], vertexes[j]))
                    );

                    matrix[i, j] = edge == null ? double.PositiveInfinity : j + 1;
                }
            return matrix;
        }

        private double[,] BuildWMatrix()
        {
            double[,] matrix = new double[len, len];

            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                {
                    // если i и j равны тогда ставим 0
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                        continue;
                    }

                    // выбираем либо только направленное через которые можно проити от вершины либо ненаправленные
                    var edge = Project.Edges.Find(e =>
                        (e.HasDirection && e.StartVertex == vertexes[i] && e.EndVertex == vertexes[j]) ||
                        (!e.HasDirection && e.ContainVertexPair(vertexes[i], vertexes[j]))
                    );

                    matrix[i, j] = edge == null ? double.PositiveInfinity : edge.Weight;
                }
            return matrix;
        }

        private void PrintWMatrix(double[,] matrix)
        {
            var stringGrid = BuildStringGridWithVertexHeaders();

            for (int row = 1; row <= len; row++)
                for (int col = 1; col <= len; col++)
                    //stringGrid[row, col] = matrix[row - 1, col - 1].ToString();
                    stringGrid[row, col] = matrix[row - 1, col - 1] == double.PositiveInfinity ? "∞" : matrix[row - 1, col - 1].ToString();

            IO.WriteLn(stringGrid);
        }

        private void PrintHMatrix(double[,] matrix)
        {
            var stringGrid = BuildStringGridWithVertexHeaders();

            for (int row = 1; row <= len; row++)
                for (int col = 1; col <= len; col++)
                {
                    double vertexIndex = matrix[row - 1, col - 1];

                    if (vertexIndex != double.PositiveInfinity)
                        vertexIndex = vertexes[(int)vertexIndex - 1].Index;

                    stringGrid[row, col] = vertexIndex == double.PositiveInfinity ? "∞" : vertexIndex.ToString();
                }
                    

            IO.WriteLn(stringGrid);
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
