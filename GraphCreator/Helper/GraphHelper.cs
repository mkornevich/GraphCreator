using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Helper
{
    public static class GraphHelper
    {
        public class ChildVertexSelector
        {
            private Project project;

            private Vertex parrentVertex;

            private List<Vertex> selectedVertexes;

            public ChildVertexSelector(Project project, Vertex parrentVertex)
            {
                this.project = project;
                this.parrentVertex = parrentVertex;
                selectedVertexes = new List<Vertex>(project.Vertexes);
            }

            public List<Vertex> Get()
            {
                return selectedVertexes;
            }
        }

        public static List<Vertex> GetLinkedVertexes(Project project, Vertex vertex, bool includeLocked = true, bool includeVisited = true, bool directionRestrict = true, bool sort = true)
        {
            var childVertexes = new List<Vertex>();
            // получение всех вершин из базовой вершины
            foreach (var edge in project.Edges)
            {
                if (!edge.ContainVertex(vertex)) continue;
                var childVertex = edge.StartVertex == vertex ? edge.EndVertex : edge.StartVertex;

                if (!includeLocked && childVertex.IsLocked) continue;
                if (!includeVisited && childVertex.IsVisited) continue;
                if (directionRestrict && edge.HasDirection && edge.EndVertex != childVertex) continue;

                childVertexes.Add(childVertex);
            }

            if (sort)
                childVertexes = childVertexes.OrderBy(v => v.Index).ToList();

            return childVertexes;
        }

        public static void ResetGraphMeta(Project project)
        {
            project.Vertexes.ForEach(v =>
            {
                v.IsLocked = false;
                v.IsVisited = false;
                v.Mark = 0;
            });

            project.Edges.ForEach(e =>
            {
                e.IsLocked = false;
            });
        }

        public static bool IsGraphWeighted(Project project)
        {
            return project.Edges.Find(edge => !edge.HasWeight) == null;
        }

        public static void ClearStyle(Project project)
        {
            project.Edges.ForEach(e => e.Style.SetDefault());
            project.Vertexes.ForEach(e => e.Style.SetDefault());
        }

        public static void Clear(Project project)
        {
            project.Vertexes.Clear();
            project.Edges.Clear();
        }
    }
}
