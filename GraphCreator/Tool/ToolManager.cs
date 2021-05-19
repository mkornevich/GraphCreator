using GraphCreator.Controller;
using GraphCreator.Tool.AddEdge;
using GraphCreator.Tool.AddVertex;
using GraphCreator.Tool.Edit;
using GraphCreator.Tool.Move;
using GraphCreator.Tool.Remove;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool
{
    class ToolManager
    {
        public List<BaseTool> Tools { get; private set; } = new List<BaseTool>();
        public BaseTool SelectedTool { get; private set; }
        public ToolManager()
        {
            RegisterTools();
        }
        private void RegisterTools()
        {
            Tools.Add(new MoveTool());
            Tools.Add(new EditTool());
            Tools.Add(new RemoveTool());
            Tools.Add(new AddEdgeTool()); 
            Tools.Add(new AddVertexTool());
        }
        public void SelectTool(BaseTool tool)
        {
            SelectedTool = tool;
        }
    }
}
