using GraphCreator.Algorithm.SimpleAlgorithms;
using GraphCreator.Algorithm.Test;
using GraphCreator.Controller;
using GraphCreator.Helper;
using GraphCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GraphCreator.Algorithm
{
    class AlgorithmManager
    {
        Project project;

        BaseAlgorithm openedAlgorithm;

        IOManager iOManager;

        IO IO;

        AlgorithmForm algorithmForm;

        Thread algorithmThread;

        public List<BaseAlgorithm> Algorithms { get; private set; } = new List<BaseAlgorithm>();

        public bool HasOpenedAlgorithm => openedAlgorithm != null;

        public AlgorithmManager(Project project, Dispatcher dispatcher)
        {
            this.project = project;
            iOManager = new IOManager(dispatcher);
            IO = new IO(iOManager, project);
            algorithmForm = new AlgorithmForm(iOManager);
            algorithmForm.FormClosing += (sender, e) => CloseOpenedAlgorithm();
            RegisterAlgorithms();
        }

        private void RegisterAlgorithms()
        {
            //Algorithms.Add(new TestAlgorithm());
            Algorithms.Add(new IncidenceMatrix());
            Algorithms.Add(new ReachableMatrix());
            Algorithms.Add(new PassInDepth());
            Algorithms.Add(new PassInWidth());
            Algorithms.Add(new DijkstraAlgorithm());
            Algorithms.Add(new FloydWarshalAlgorithm());
            Algorithms.Add(new KruskalSpanningTree());
            Algorithms.Add(new PrimSpanningTree());
            Algorithms.Add(new EulerCycle());
        }

        public void OpenAlgorithm(BaseAlgorithm algorithm)
        {
            if (HasOpenedAlgorithm) throw new Exception("Прежде чем открыть новый алгоритм необходимо закрыть предыдущий.");

            openedAlgorithm = algorithm;
            openedAlgorithm.Project = project;
            openedAlgorithm.IO = IO;

            GraphHelper.ResetGraphMeta(project);
            GraphHelper.ClearStyle(project);

            algorithmThread = new Thread(() =>
            {
                try
                {
                    openedAlgorithm.Run();
                }
                catch (ThreadInterruptedException) { }
            });
            algorithmThread.Name = "AlgorithmThread";
            algorithmThread.Start(); 

            algorithmForm.OnAlgorithmOpened(openedAlgorithm);
            algorithmForm.Show();
        }

        public void CloseOpenedAlgorithm()
        {
            algorithmThread.Interrupt();
            algorithmThread = null;
            openedAlgorithm = null;
        }

        public void OnGraphPartSelectionChanged()
        {
            string graphPartStr = null;
            if (project.State.SelectedGraphPart == GraphPart.Edge)
                graphPartStr = ((Edge)project.State.SelectedObject).ToString();

            if (project.State.SelectedGraphPart == GraphPart.Vertex)
                graphPartStr = ((Vertex)project.State.SelectedObject).ToString();

            algorithmForm.OnGraphPartSelectionChanged(graphPartStr);
        }
    }
}
