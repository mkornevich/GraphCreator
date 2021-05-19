using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Controller
{
    abstract class BaseController
    {
        public Project Project { get; set; }

        public MouseEventArgs MouseEventArgs { get; set; }

        private Pos mousePos = new Pos();

        public Pos MousePos => mousePos.Set(MouseEventArgs.X, MouseEventArgs.Y);

        public int X => MouseEventArgs.X;
        public int Y => MouseEventArgs.Y;

        public abstract void OnMouseDown();

        public abstract void OnMouseUp();

        public abstract void OnMouseMove();
    }
}
