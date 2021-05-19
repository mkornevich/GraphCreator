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
    class EulerCycle : BaseAlgorithm
    {
        public EulerCycle()
        {
            Name = "Эйлеров цикл";
            Description = "Данный алгоритм позволяет найти Эйлеров цикл в графе.";
        }

        public override void Run()
        {
            if (HasEulerCycle())
                IO.WriteLn("Эйлеров цикл существует.");
            else
            {
                IO.WriteLn("Эйлеров цикл не существует.");
                return;
            }

            var vertexStack = new Stack<Vertex>();
            var path = new Path();

            vertexStack.Push(Project.Vertexes[0]);

            while (vertexStack.Count > 0)
            {
                var currVertex = vertexStack.Peek();

                int childEdgeCount = Project.Edges.Count(edge => !edge.IsLocked && edge.ContainVertex(currVertex));

                if (childEdgeCount == 0)
                {
                    path.AddStep(currVertex);
                    vertexStack.Pop();
                }
                else
                {
                    var linkedEdge = Project.Edges.Find(edge => !edge.IsLocked && edge.ContainVertex(currVertex));
                    linkedEdge.IsLocked = true;
                    var linkedOppositeVertex = linkedEdge.GetOppositeVertex(currVertex);
                    vertexStack.Push(linkedOppositeVertex);
                }

            }

            IO.WriteLn(path);
        }

        private bool HasEulerCycle()
        {
            foreach (var vertex in Project.Vertexes)
            {
                int childEdgeCount = GraphHelper.GetLinkedVertexes(Project, vertex).Count;
                if (childEdgeCount % 2 != 0) 
                    return false;
            }
            return true;
        }
    }
}
