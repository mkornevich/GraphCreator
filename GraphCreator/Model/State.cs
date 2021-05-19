using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Model
{
    public class State
    {
        // ------- Selected
        public GraphPart SelectedGraphPart { get; set; } = GraphPart.None;
        public object SelectedObject { get; set; }

        // ------- Hovered
        public GraphPart HoveredGraphPart { get; set; } = GraphPart.None;
        public object HoveredObject { get; set; }

        // ------- NewEdgeLine
        public bool NewLineVisible { get; set; } = false;
        public Pos StartNewLinePos { get; private set; } = new Pos();
        public Pos EndNewLinePos { get; private set; } = new Pos();

    }
}
