using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Structure
{
    class Matrix
    {
        public List<string> ColTitles { get; private set; } = new List<string>();
        public List<string> RowTitles { get; private set; } = new List<string>();
        public bool EnableColTitles { get; set; } = true;
        public bool EnableRowTitles { get; set; } = true;

        public class Cell
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public string Content { get; set; }
        }
    }
}
