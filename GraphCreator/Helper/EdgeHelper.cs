using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Helper
{
    public static class EdgeHelper
    {

        public static bool FilterAtAboutPos(Edge edge, Pos pos)
        {
            Pos start = edge.StartVertex.Pos;
            Pos end = edge.EndVertex.Pos;
            Pos center = MathHelper.GetCenterPos(start, end);
            int length = MathHelper.Distance(start, end);
            int allowRadius = length / 2;

            if (MathHelper.Distance(center, pos) > allowRadius) return false;
            if (MathHelper.DistanceToLine(start, end, pos) > 5) return false;
            return true;
        }

        public static bool IsStringEqualsEdge(string edgeStr, Edge edge)
        {
            string[] edgeVertexes = edgeStr.Split('-');
            if (edgeVertexes.Length != 2)
                return false;
            try
            {
                if (
                    (edge.StartVertex.Index == int.Parse(edgeVertexes[0]) && edge.EndVertex.Index == int.Parse(edgeVertexes[1])) ||
                    (edge.StartVertex.Index == int.Parse(edgeVertexes[1]) && edge.EndVertex.Index == int.Parse(edgeVertexes[0]))
                    )
                    return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public static Edge GetByVertexPair(Project project, Vertex firstVertex, Vertex secondVertex)
        {
            return project.Edges.Find(edge => edge.ContainVertexPair(firstVertex, secondVertex));
        }
    }
}
