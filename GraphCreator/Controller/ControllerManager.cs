using GraphCreator.Tool;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCreator.Controller
{
    class ControllerManager
    {
        private ToolManager toolManager;
        private Project project;
        private Panel drawPanel;
        private MainController mainController;

        public delegate void SelectionChangedHandler();
        public event SelectionChangedHandler SelectionChanged;

        public ControllerManager(ToolManager toolManager, Project project, Panel drawPanel)
        {
            this.toolManager = toolManager;
            this.project = project;
            this.drawPanel = drawPanel;
            mainController = new MainController();
            mainController.SelectionChanged += () => SelectionChanged?.Invoke();
            InstallListeners();
        }

        private List<BaseController> GetCurrentControllers()
        {
            List<BaseController> controllers = new List<BaseController>();
            controllers.Add(mainController);
            if (toolManager.SelectedTool?.Controllers != null)
                controllers.AddRange(toolManager.SelectedTool.Controllers);
            return controllers;
        }

        private void InstallListeners()
        {
            drawPanel.MouseDown += OnMouseDown;
            drawPanel.MouseUp += OnMouseUp;
            drawPanel.MouseMove += OnMouseMove;
        }

        private void InitController(BaseController controller)
        {
            controller.Project = project;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var controllers = GetCurrentControllers();
            foreach (var controller in controllers)
            {
                InitController(controller);
                controller.MouseEventArgs = e;
                controller.OnMouseMove();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            var controllers = GetCurrentControllers();
            foreach (var controller in controllers)
            {
                InitController(controller);
                controller.MouseEventArgs = e;
                controller.OnMouseUp();
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            var controllers = GetCurrentControllers();
            foreach (var controller in controllers)
            {
                InitController(controller);
                controller.MouseEventArgs = e;
                controller.OnMouseDown();
            }
        }
    }
}
