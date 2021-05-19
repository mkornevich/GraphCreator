using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Drawer
{
    class NewLineDrawer : BaseDrawer
    {
        public override void Draw()
        {
            if (Project.State.NewLineVisible)
            {
                int x = Project.State.StartNewLinePos.X;
                int y = Project.State.StartNewLinePos.Y;
                int toX = Project.State.EndNewLinePos.X;
                int toY = Project.State.EndNewLinePos.Y;

                Graphics.DrawLine(new Pen(Color.Red, 1), x, y, toX, toY);
            }
        }
    }
}
