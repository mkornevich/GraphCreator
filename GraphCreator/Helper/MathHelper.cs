using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Helper
{
    static class MathHelper
    {
        public static int Distance(int x, int y, int x1, int y1)
        {
            int xLen = Math.Abs(x - x1);
            int yLen = Math.Abs(y - y1);
            return (int)Math.Sqrt(Math.Pow(xLen, 2) + Math.Pow(yLen, 2));
        }

        public static int Distance(Pos pos, Pos pos1)
        {
            return Distance(pos.X, pos.Y, pos1.X, pos1.Y);
        }

        public static int DistanceToLine(Pos startLine, Pos endLine, Pos from)
        {
            double x1 = startLine.X;
            double y1 = startLine.Y;
            double x2 = endLine.X;
            double y2 = endLine.Y;
            double mx = from.X;
            double my = from.Y;
            double result = Math.Abs((y2 - y1) * mx - (x2 - x1) * my + x2 * y1 - y2 * x1) / Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
            return (int)result;
        }

        public static Pos GetCenterPos(Pos start, Pos end)
        {
            Pos result = new Pos();
            result.X = (start.X + end.X) / 2;
            result.Y = (start.Y + end.Y) / 2;
            return result;
        }

        public static double GetLineAngle(Pos baseStart, Pos end)
        {
            double ax = 1;
            double ay = 0;
            double bx = end.X - baseStart.X;
            double by = end.Y - baseStart.Y;

            double axb = ax * bx + ay * by;
            double ma = Math.Sqrt(ax * ax + ay * ay);
            double mb = Math.Sqrt(bx * bx + by * by);
            double angle = Math.Acos(axb / (ma * mb));
            angle = baseStart.Y < end.Y ? angle - Math.PI : Math.PI - angle;
            return angle;
        }

    }
}
