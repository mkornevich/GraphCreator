using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Drawer
{
    class SelectedHoweredDrawer : BaseDrawer
    {
        private Pen hoverVertexPen = new Pen(Color.Gray, 1);
        private Pen selectVertexPen = new Pen(Color.Black, 1);

        private Pen hoverEdgePen = new Pen(Color.FromArgb(70, 137, 137, 137), 5);
        private Pen selectEdgePen = new Pen(Color.FromArgb(100, 137, 137, 137), 5);

        public SelectedHoweredDrawer()
        {
            hoverVertexPen.DashStyle = DashStyle.Dash;
        }

        public override void Draw()
        {
            if (Project.State.HoveredGraphPart == GraphPart.Vertex)
            {
                var vertex = (Vertex)Project.State.HoveredObject;
                int x = vertex.Pos.X;
                int y = vertex.Pos.Y;
                int r = Vertex.RADIUS + 2;

                Graphics.DrawEllipse(hoverVertexPen, x - r, y - r, r * 2, r * 2);
            }

            if (Project.State.SelectedGraphPart == GraphPart.Vertex)
            {
                var vertex = (Vertex)Project.State.SelectedObject;
                int x = vertex.Pos.X;
                int y = vertex.Pos.Y;
                int r = Vertex.RADIUS + 2;

                Graphics.DrawEllipse(selectVertexPen, x - r, y - r, r * 2, r * 2);
            }

            if (Project.State.HoveredGraphPart == GraphPart.Edge)
            {
                var edge = (Edge)Project.State.HoveredObject;
                int x = edge.StartVertex.Pos.X;
                int y = edge.StartVertex.Pos.Y;
                int x1 = edge.EndVertex.Pos.X;
                int y1 = edge.EndVertex.Pos.Y;

                Graphics.DrawLine(hoverEdgePen, x, y, x1, y1);
            }

            if (Project.State.SelectedGraphPart == GraphPart.Edge)
            {
                var edge = (Edge)Project.State.SelectedObject;
                int x = edge.StartVertex.Pos.X;
                int y = edge.StartVertex.Pos.Y;
                int x1 = edge.EndVertex.Pos.X;
                int y1 = edge.EndVertex.Pos.Y;

                Graphics.DrawLine(selectEdgePen, x, y, x1, y1);
            }
        }
    }
}
