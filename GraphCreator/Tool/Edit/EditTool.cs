using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool.Edit
{
    class EditTool : BaseTool
    {
        public EditTool()
        {
            Controllers.Add(new EditController());
            Name = "Редактировать";
            Description = "Позволяет редактировать вершину или ребро. Просто кликните на нужный элемент.";
        }
    }
}
