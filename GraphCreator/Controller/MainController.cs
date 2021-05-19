using GraphCreator.Helper;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Controller
{
    class MainController : BaseController
    {

        public delegate void SelectionChangedHandler();

        public event SelectionChangedHandler SelectionChanged;

        public override void OnMouseDown()
        {

            Vertex newSelectVertex = Project.Vertexes
                .Reverse<Vertex>()
                .ToList()
                .Find(vertex => VertexHelper.FilterAtAboutPos(vertex, MousePos));

            if (newSelectVertex != null)
            {
                Project.State.SelectedGraphPart = GraphPart.Vertex;
                Project.State.SelectedObject = newSelectVertex;
                SelectionChanged?.Invoke();
                return;
            }

            Edge newSelectEdge = Project.Edges
                .Reverse<Edge>()
                .ToList()
                .Find(edge => EdgeHelper.FilterAtAboutPos(edge, MousePos));

            if (newSelectEdge != null)
            {
                Project.State.SelectedGraphPart = GraphPart.Edge;
                Project.State.SelectedObject = newSelectEdge;
                SelectionChanged?.Invoke();
                return;
            }

            Project.State.SelectedGraphPart = GraphPart.None;
        }

        public override void OnMouseUp()
        {

        }

        public override void OnMouseMove()
        {
            Vertex newHoveredVertex = Project.Vertexes
                .Reverse<Vertex>()
                .ToList()
                .Find(vertex => VertexHelper.FilterAtAboutPos(vertex, MousePos));

            if (newHoveredVertex != null)
            {
                Project.State.HoveredGraphPart = GraphPart.Vertex;
                Project.State.HoveredObject = newHoveredVertex;
                return;
            }

            Edge newHoveredEdge = Project.Edges
                .Reverse<Edge>()
                .ToList()
                .Find(edge => EdgeHelper.FilterAtAboutPos(edge, MousePos));

            if (newHoveredEdge != null)
            {
                Project.State.HoveredGraphPart = GraphPart.Edge;
                Project.State.HoveredObject = newHoveredEdge;
                return;
            }

            Project.State.HoveredGraphPart = GraphPart.None;
        }
    }
}
