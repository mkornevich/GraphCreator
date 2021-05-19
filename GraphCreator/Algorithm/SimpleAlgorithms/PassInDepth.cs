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
    class PassInDepth : BaseAlgorithm
    {

        // инициализировать только в run
        List<Vertex> passedVertexes;

        public PassInDepth()
        {
            Name = "Обход в глубину";
            Description = "Данный алгоритм выполняет обход графа в глубину.";
        }

        private void Recursion(Vertex parrent)
        {
            if (parrent.IsVisited) return;
            parrent.IsVisited = true;
            passedVertexes.Add(parrent);

            // получаем не посещенные вершины у данной вершины и посещаем рекурсивно их
            var childVertexes = GraphHelper.GetLinkedVertexes(Project, parrent, true, false);
            childVertexes.ForEach(Recursion);

        }

        public override void Run()
        {
            passedVertexes = new List<Vertex>();

            var startVertex = IO.ReadLnExistVerex("Введите начальную вершину:");
            startVertex.Style.LineColor = Color.Green;
            startVertex.Style.LineWidth = 3;

            // начинаем проход с первой вершины
            Recursion(startVertex);

            IO.WriteLn("Результат обхода:");
            passedVertexes.ForEach(vertex => IO.Write(vertex + " "));
        }

    }
}
