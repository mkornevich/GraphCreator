using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.AddEdge
{
    class AddEdgeTool : BaseTool
    {
        public AddEdgeTool()
        {
            Description = "Данный инструмент предназначен для добавления новых ребер. Просто соедините 2 вершины мышкой.";
            Name = "Добавить ребро";
            Controllers.Add(new AddEdgeController());
        }
    }
}
