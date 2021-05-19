using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.Remove
{
    class RemoveTool : BaseTool
    {
        public RemoveTool()
        {
            Description = "Данный инструмент позволяет удалять ребра или вершины. Достаточно просто кликнуть на необходимый элемент.";
            Name = "Удалить";
            Controllers.Add(new RemoveController());
        }
    }
}
