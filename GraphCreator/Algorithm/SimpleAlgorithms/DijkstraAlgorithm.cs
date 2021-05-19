using GraphCreator.Helper;
using GraphCreator.Model;
using GraphCreator.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm.SimpleAlgorithms
{
    class DijkstraAlgorithm : BaseAlgorithm
    {
        Queue<Vertex> nextVertexesQueue;

        public DijkstraAlgorithm()
        {
            Name = "Алгоритм Дейкстры";
            Description = "Данный алгоритм позволяет найти минимальные пути от выбранной вершины до всех остальных вершин.";
        }

        private void DoCalculateMark()
        {
            var parrentVertex = nextVertexesQueue.Dequeue();

            // выбераем дочерние вершины, и сортируем их по весу смежного ребра.
            var childVertexes = GraphHelper.GetLinkedVertexes(Project, parrentVertex, true, false);

            // расчитываем и устанавливаем маркеры
            childVertexes.ForEach(vertex =>
            {
                var edgeWeight = EdgeHelper.GetByVertexPair(Project, parrentVertex, vertex).Weight;
                var newMark = edgeWeight + parrentVertex.Mark;
                vertex.Mark = newMark < vertex.Mark ? newMark : vertex.Mark;
            });

            // выбераем еще не заблокированные вершины
            childVertexes = childVertexes.FindAll(vertex => !vertex.IsLocked);

            // блокируем их чтоб повторно не пройтись по ним
            childVertexes.ForEach(v => v.IsLocked = true);

            // кладем в очередь для дальнейшей их обработки
            childVertexes.ForEach(nextVertexesQueue.Enqueue);
        }

        public override void Run()
        {
            nextVertexesQueue = new Queue<Vertex>();

            if (!GraphHelper.IsGraphWeighted(Project))
            {
                IO.WriteLn("Для выполнения данного алгоритма граф должен быть взвешанным.");
                return;
            }

            // вводим начальную вершину
            var startVertex = IO.ReadLnExistVerex("Введите начальную вершину:");
            startVertex.Style.LineColor = Color.Green;
            startVertex.Style.LineWidth = 3;

            // ставим маркер в бесконечность у всех вершин
            Project.Vertexes.ForEach(v => v.Mark = double.PositiveInfinity);

            // У начальной вершины ставим маркер в 0
            startVertex.Mark = 0;

            // выполняем просчет маркеров вершин
            startVertex.IsLocked = true;
            nextVertexesQueue.Enqueue(startVertex);
            while (nextVertexesQueue.Count > 0) DoCalculateMark();

            // вывод путей
            IO.WriteLn("Пути от начальной вершины до остальных доступных вершин:");
            foreach (var vertex in Project.Vertexes)
            {
                if (vertex == startVertex) continue;
                IO.WriteLn(MakePathFromStartVertex(startVertex, vertex));
            }
        }

        private Path MakePathFromStartVertex(Vertex start, Vertex to)
        {
            var path = new Path();
            var currVertex = to;
            do
            {
                path.AddStep(currVertex);
                currVertex = GraphHelper.GetLinkedVertexes(Project, currVertex)
                    .Find(vertex => currVertex.Mark - EdgeHelper.GetByVertexPair(Project, currVertex, vertex).Weight == vertex.Mark);
            } while (currVertex != start);
            path.AddStep(currVertex);
            path.Reverse();
            return path;
        }
    }
}
