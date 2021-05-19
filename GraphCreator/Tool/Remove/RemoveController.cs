using GraphCreator.Controller;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.Remove
{
    class RemoveController : BaseController
    {
        public override void OnMouseDown()
        {
            var state = Project.State;

            if (state.SelectedGraphPart == GraphPart.Edge)
            {
                Project.Edges.Remove((Edge)state.SelectedObject);
            }

            if (state.SelectedGraphPart == GraphPart.Vertex)
            {
                var removeVertex = (Vertex)state.SelectedObject;
                Project.Edges.RemoveAll(edge => edge.ContainVertex(removeVertex));
                Project.Vertexes.Remove(removeVertex);
            }

            if (state.SelectedGraphPart != GraphPart.None)
            {
                state.SelectedGraphPart = GraphPart.None;
                state.HoveredGraphPart = GraphPart.None;
            }
        }

        public override void OnMouseMove()
        {
            
        }

        public override void OnMouseUp()
        {
            
        }
    }
}
