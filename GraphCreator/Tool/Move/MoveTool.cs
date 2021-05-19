using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.Move
{
    class MoveTool : BaseTool
    {
        public MoveTool()
        {
            Description = "Данный инструмент предназначен для перемещения вершин. Просто кликните и перетащите.";
            Name = "Переместить";
            Controllers.Add(new MoveController());
        }
    }
}
