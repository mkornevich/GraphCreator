using GraphCreator.Controller;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.AddVertex
{
    class AddVertexController : BaseController
    {
        public override void OnMouseDown()
        {
            var vertex = new Vertex(GetFreeVertexIndex(), new Pos(X, Y));
            Project.Vertexes.Add(vertex);
        }

        public override void OnMouseMove()
        {

        }

        public override void OnMouseUp()
        {

        }

        private int GetFreeVertexIndex()
        {
            int currIndex = 0;
            do
            {
                currIndex++;
            } while (Project.Vertexes.Exists(vertex => vertex.Index == currIndex));
            return currIndex;
        }
    }
}
