using GraphCreator.Controller;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Tool.AddEdge
{
    class AddEdgeController : BaseController
    {
        Vertex startVertex;

        public override void OnMouseUp()
        {
            Project.State.NewLineVisible = false;
            if (Project.State.HoveredGraphPart == GraphPart.Vertex)
            {
                var endVertex = (Vertex)Project.State.HoveredObject;
                var newEdge = new Edge(startVertex, endVertex);

                if (!Project.Edges.Exists(edge => edge.ContainVertexPair(newEdge)))
                {
                    Project.Edges.Add(newEdge);
                }
                else
                {
                    MessageBox.Show("Для 2 вершин допустимо иметь только одно ребро.", "Ошибка");
                }
            }
        }

        public override void OnMouseDown()
        {
            if (Project.State.SelectedGraphPart == GraphPart.Vertex)
            {
                startVertex = (Vertex)Project.State.SelectedObject;
                Project.State.StartNewLinePos.Set(startVertex.Pos);
                Project.State.EndNewLinePos.Set(X, Y);
                Project.State.NewLineVisible = true;
            }
        }

        public override void OnMouseMove()
        {
            if (Project.State.NewLineVisible)
                Project.State.EndNewLinePos.Set(X, Y);
        }
    }
}
