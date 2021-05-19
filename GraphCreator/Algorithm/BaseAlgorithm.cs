using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Algorithm
{
    public abstract class BaseAlgorithm
    {
        public Project Project { get; set; }
        public string Name { get; protected set; } = "Не указано";
        public string Description { get; protected set; } = "Не указано";
        public IO IO { get; set; }
        abstract public void Run();
    }
}
