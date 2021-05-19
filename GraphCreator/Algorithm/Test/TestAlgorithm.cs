using GraphCreator.Model;
using GraphCreator.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Algorithm.Test
{
    class TestAlgorithm : BaseAlgorithm
    {
        public TestAlgorithm()
        {
            Name = "Тестовый алгоритм";
            Description = "Данный тестовый алгоритм предназначен для тестирования.";
        }

        public override void Run()
        {

            var vertex = IO.ReadLnExistVerex("Введите начальную вершниу:");
            vertex.Style.LineWidth = 3;
            vertex.Style.LineColor = Color.Orange;
        }
    }
}
