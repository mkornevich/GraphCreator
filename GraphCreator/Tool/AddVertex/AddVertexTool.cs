using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.AddVertex
{
    class AddVertexTool : BaseTool
    {
        public AddVertexTool()
        {
            Description = "Данный инструмент предназначен для добавления новых вершин. Просто кликните в нужное место для создания новой вершины.";
            Name = "Добавить вершину";
            Controllers.Add(new AddVertexController());
        }
    }
}
