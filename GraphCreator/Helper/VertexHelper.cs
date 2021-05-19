using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Helper
{
    public static class VertexHelper
    {
        public static bool FilterAtAboutPos(Vertex vertex, Pos pos)
        {
            return MathHelper.Distance(pos, vertex.Pos) <= Vertex.RADIUS;
        }

        public static bool IsStringEqualsVertex(string vertexStr, Vertex vertex)
        {
            try
            {
                return int.Parse(vertexStr) == vertex.Index;
            } catch (Exception)
            {
                return false;
            }
        }

    }
}
