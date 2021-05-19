using GraphCreator.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Tool
{
    abstract class BaseTool
    {
        public List<BaseController> Controllers { get; protected set; } = new List<BaseController>();
        public string Description { get; protected set; } = "Описания нету!";
        public string Name { get; protected set; } = "Имени нету";

    }
}
