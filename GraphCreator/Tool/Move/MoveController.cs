using GraphCreator.Controller;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Tool.Move
{
    class MoveController : BaseController
    {
        Vertex moveVertex;
        Pos offsetPos = new Pos();

        public override void OnMouseUp()
        {
            moveVertex = null;
        }

        public override void OnMouseDown()
        {
            if (Project.State.SelectedGraphPart != GraphPart.Vertex) return;
            moveVertex = (Vertex)Project.State.SelectedObject;
            offsetPos.Set(moveVertex.Pos).Sub(X, Y);
        }

        public override void OnMouseMove()
        {
            if (moveVertex == null) return;
            moveVertex.Pos.Set(X, Y).Add(offsetPos);
        }
    }
}
