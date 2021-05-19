using GraphCreator.Controller;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.Edit
{
    class EditController : BaseController
    {

        private EditEdgeForm editEdgeForm;

        private EditVertexForm editVertexForm;

        public EditController()
        {
            editEdgeForm = new EditEdgeForm();
            editVertexForm = new EditVertexForm();
        }

        public override void OnMouseDown()
        {
            if (Project.State.SelectedGraphPart == GraphPart.Edge)
            {
                editEdgeForm.EditEdge = (Edge)Project.State.SelectedObject;
                editEdgeForm.ShowDialog();
            }

            if (Project.State.SelectedGraphPart == GraphPart.Vertex)
            {
                editVertexForm.Project = Project;
                editVertexForm.EditVertex = (Vertex)Project.State.SelectedObject;
                editVertexForm.ShowDialog();
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
