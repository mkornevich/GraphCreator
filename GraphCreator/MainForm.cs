using GraphCreator.Controller;
using GraphCreator.Drawer;
using GraphCreator.Tool;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphCreator.Algorithm;
using System.Windows.Threading;
using GraphCreator.Helper;

namespace GraphCreator
{
    public partial class MainForm : Form
    {

        private Project Project { get; set; }
        private ControllerManager ControllerManager { get; set; }
        private DrawerManager DrawerManager { get; set; }
        private ToolManager ToolManager { get; set; }
        private AlgorithmManager AlgorithmManager { get; set; }

        private void InitCore()
        {
            Project = new Project();
            
            DrawerManager = new DrawerManager(Project, drawPanel);
            DrawerManager.StartAutoDraw();
            ToolManager = new ToolManager();
            ControllerManager = new ControllerManager(ToolManager, Project, drawPanel);
            AlgorithmManager = new AlgorithmManager(Project, Dispatcher.CurrentDispatcher);

            ControllerManager.SelectionChanged += AlgorithmManager.OnGraphPartSelectionChanged;
        }

        public MainForm()
        {
            InitializeComponent();
            InitCore();

            var v1 = new Vertex(1, new Pos(20, 20));
            var v2 = new Vertex(2, new Pos(100, 20));
            var v3 = new Vertex(3, new Pos(20, 200));
            var v4 = new Vertex(4, new Pos(100, 200));
            var v5 = new Vertex(5, new Pos(50, 200));
            var v6 = new Vertex(6, new Pos(100, 70));

            Project.Vertexes.Add(v1);
            Project.Vertexes.Add(v2);
            Project.Vertexes.Add(v3);
            Project.Vertexes.Add(v4);
            Project.Vertexes.Add(v5);
            Project.Vertexes.Add(v6);

            Project.Edges.Add(new Edge(v1, v2) { HasWeight = true, Weight = 7 });
            Project.Edges.Add(new Edge(v1, v3) { HasWeight = true, Weight = 9 });
            Project.Edges.Add(new Edge(v1, v6) { HasWeight = true, Weight = 14 });
            Project.Edges.Add(new Edge(v3, v6) { HasWeight = true, Weight = 2 });
            Project.Edges.Add(new Edge(v3, v2) { HasWeight = true, Weight = 10 });
            Project.Edges.Add(new Edge(v3, v4) { HasWeight = true, Weight = 11 });
            Project.Edges.Add(new Edge(v2, v4) { HasWeight = true, Weight = 15 });
            Project.Edges.Add(new Edge(v4, v5) { HasWeight = true, Weight = 6 });
            Project.Edges.Add(new Edge(v5, v6) { HasWeight = true, Weight = 9 });

            InitToolsListBox();            
            InitAlgorithmsListBox();        
        }

        private void InitToolsListBox()
        {
            ToolsListBox.Items.Clear();
            foreach (var tool in ToolManager.Tools)
                ToolsListBox.Items.Add(tool.Name);
            ToolsListBox.SelectedIndex = 0;
        }

        private void ToolsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ToolsListBox.SelectedIndex;
            if (index < 0) return;
            var tool = ToolManager.Tools[index];
            ToolManager.SelectTool(tool);
            descriptionTextBox.Text = tool.Description;
        }

        private void InitAlgorithmsListBox()
        {
            algorithmsListBox.Items.Clear();
            foreach (var algorithm in AlgorithmManager.Algorithms)
                algorithmsListBox.Items.Add(algorithm.Name);
        }



        private void algorithmsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (AlgorithmManager.HasOpenedAlgorithm)
            {
                MessageBox.Show("Нельзя открыть новый алгоритм пока не закрыт текущий!", "Ошибка");
                return;
            }

            int index = algorithmsListBox.SelectedIndex;

            if (index < 0) return;

            var openAlgorithm = AlgorithmManager.Algorithms[index];
            AlgorithmManager.OpenAlgorithm(openAlgorithm);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (AlgorithmManager.HasOpenedAlgorithm)
            {
                
                e.Cancel = true;
                MessageBox.Show("Во время работы алгоритма нельзя пользоваться инструментами", "Ошибка");
                return;
            }

            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            ToolsListBox.SelectedIndex = -1;
            ToolsListBox.SelectedIndex = 0;
            if (tabControl1.SelectedTab == algorithmTab)
            {
                algorithmsListBox.SelectedIndex = -1;
                algorithmsListBox.SelectedIndex = 0;
            }

            clearBtn.Visible = tabControl1.SelectedTab == toolTab;
        }

        private void algorithmsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = algorithmsListBox.SelectedIndex;
            if (index < 0) return;

            var algorithm = AlgorithmManager.Algorithms[index];
            descriptionTextBox.Text = algorithm.Description;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            GraphHelper.Clear(Project);
        }
    }
}
