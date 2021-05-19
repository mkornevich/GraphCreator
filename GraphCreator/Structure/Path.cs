using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Structure
{
    class Path : List<Vertex>
    {
        public enum PathType
        {
            Incorrect,
            Path,
            Cycle,
        }

        public void AddStep(Vertex vertex) => Add(vertex);

        public PathType GetPathType()
        {
            if (Count < 2) return PathType.Incorrect;
            if (this.First() == this.Last()) return PathType.Cycle;
            return PathType.Path;
        }

        public override string ToString()
        {
            string pathType = PathTypeToString(GetPathType());
            string path = Count > 0 ? string.Join(" ", this) : "Путь не содержит ни одной вершины!";
            return pathType + ": " + path;
        }

        public static string PathTypeToString(PathType pathType)
        {
            switch (pathType)
            {
                case PathType.Cycle:
                    return "Цикл";
                case PathType.Path:
                    return "Путь";
                default:
                    return "Некорректный путь";
            }
        }
    }
}
