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
    class PassInWidth : BaseAlgorithm
    {
        // инициализировать только в run
        List<Vertex> visitedVertexes;
        Queue<Vertex> nextVertexesQueue;

        public PassInWidth()
        {
            Name = "Обход в ширину";
            Description = "Данный алгоритм выполняет обход графа в ширину.";
        }

        public void DoEnqueue()
        {
            var nextVertex = nextVertexesQueue.Dequeue();
            //nextVertex.IsVisited = true;
            visitedVertexes.Add(nextVertex);

            var childVertexes = GraphHelper.GetLinkedVertexes(Project, nextVertex, false);
            childVertexes.ForEach(v => v.IsLocked = true);
            childVertexes.ForEach(nextVertexesQueue.Enqueue);
        }

        public override void Run()
        {
            visitedVertexes = new List<Vertex>();
            nextVertexesQueue = new Queue<Vertex>();

            var startVertex = IO.ReadLnExistVerex("Введите начальную вершину:");
            startVertex.Style.LineColor = Color.Green;
            startVertex.Style.LineWidth = 3;

            startVertex.IsLocked = true;
            nextVertexesQueue.Enqueue(startVertex);
            while (nextVertexesQueue.Count > 0) DoEnqueue();

            IO.WriteLn("Результат обхода:");
            visitedVertexes.ForEach(vertex => IO.Write(vertex + " "));
        }
    }
}
